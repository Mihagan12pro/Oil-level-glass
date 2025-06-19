using Kompas6Constants3D;
using Kompas6API5;
using System.Text.RegularExpressions;
using System.CodeDom;
namespace Oil_level_glass.Kompas_classes
{
    internal abstract class KompasDetail : IKompasModel
    {
        public ksPart Part { get; protected set; }
        public Color ModelColor { get; set; }
        public string? SavePath { get; set; }
        public string? ModelName { get; set; }
        public string? FileExtension { get; set; }
        public ksDocument3D? Document3D { get; set; }

        protected SketchShell Sketch(ksEntity plane, List<Entity2D> entity2Ds)
        {
            SketchShell sketchShell = new SketchShell();

            try
            {
                sketchShell.Sketch = (ksEntity)Part.NewEntity((short)Obj3dType.o3d_sketch);


                sketchShell.SketchDefinition = (ksSketchDefinition)sketchShell.Sketch.GetDefinition();
                sketchShell.SketchDefinition.SetPlane(plane);

                sketchShell.Sketch.Create();


                ksDocument2D document2D = (ksDocument2D)sketchShell.SketchDefinition.BeginEdit();

                foreach (var ent in entity2Ds)
                {
                    if (ent.GetType() == typeof(LineSegment))
                    {
                        LineSegment lineSegment = (LineSegment)ent;
                        document2D.ksLineSeg(lineSegment.StartPoint.X, lineSegment.StartPoint.Y, lineSegment.EndPoint.X, lineSegment.EndPoint.Y, lineSegment.LineType);
                    }
                    else if (ent.GetType() == typeof(Circle))
                    {
                        Circle circle = (Circle)ent;
                        document2D.ksCircle(circle.Center.X,circle.Center.Y,circle.Radius,circle.LineType);
                    }
                }

                sketchShell.SketchDefinition.EndEdit();

                sketchShell.Ok = true;
            }
            catch
            {
                IKompasModel.Kompas.ksMessage("Ошибка при создании эскиза!");

                sketchShell.Ok = false;
            }
        
            return sketchShell;
        }
    

        protected BossExtrusionShell BossExtrusion(List<SketchShell> sketchShells,bool side1,Kompas6Constants3D.Direction_Type direction,double depth,double draftValue, bool draftOutward)
        {
            BossExtrusionShell bossExtrusion = new BossExtrusionShell();

            bossExtrusion.BossExtrusion = Part.NewEntity((short)Obj3dType.o3d_bossExtrusion);

            bossExtrusion.BossExtrusionDefinition = bossExtrusion.BossExtrusion.GetDefinition();

            foreach(var sketch in sketchShells)
            {
                bossExtrusion.BossExtrusionDefinition.SetSketch(sketch.Sketch);
            }

            bossExtrusion.BossExtrusionDefinition.SetSideParam(side1,(short)direction,depth,draftValue, draftOutward);
            bossExtrusion.BossExtrusion.Create();

            return bossExtrusion;
        }


        protected CutRotatedShell CutRotate(List<SketchShell> sketchShells)
        {
            CutRotatedShell cutRotatedShell = new CutRotatedShell();

            cutRotatedShell.CutRotated = Part.NewEntity((short)Obj3dType.o3d_cutRotated);

            cutRotatedShell.CutRotatedDefinition = cutRotatedShell.CutRotated.GetDefinition();

            foreach(var sketch in sketchShells)
            {
                cutRotatedShell.CutRotatedDefinition.SetSketch(sketch.Sketch);
            }

            cutRotatedShell.CutRotatedDefinition.SetSideParam(false,360);

            cutRotatedShell.CutRotated.Create();

            return cutRotatedShell;
        }


        protected CircularCopyShell CircularCopy(List<ICopy> copies,int countOfCopies,ksEntity plane1,ksEntity plane2,double angle = 360)
        {
            ksEntity axis2Planes = Part.NewEntity((short)Obj3dType.o3d_axis2Planes);
            ksAxis2PlanesDefinition axis2PlanesDefinition = axis2Planes.GetDefinition();

            axis2PlanesDefinition.SetPlane(1, plane1);
            axis2PlanesDefinition.SetPlane(2, plane2);

            axis2Planes.Create();


            CircularCopyShell circularCopyShell = new CircularCopyShell();

            circularCopyShell.CircularCopy = Part.NewEntity((short)Obj3dType.o3d_circularCopy);
            circularCopyShell.CircularCopyDefinition = circularCopyShell.CircularCopy.GetDefinition();

            circularCopyShell.CircularCopyDefinition.count1 = countOfCopies;

            circularCopyShell.CircularCopyDefinition.SetAxis(axis2Planes);

            circularCopyShell.CircularCopyDefinition.SetCopyParamAlongDir(countOfCopies,angle, true,true);

            ksEntityCollection entityCollection = circularCopyShell.CircularCopyDefinition.GetOperationArray();
            entityCollection.Clear();
            
            foreach(ICopy copy in copies)
            {
                if (copy.GetType() == typeof(BossExtrusionShell))
                {
                    entityCollection.Add((copy as BossExtrusionShell).BossExtrusion);
                }
               else if (copy.GetType() == typeof(CutRotatedShell))
                {
                    entityCollection.Add((copy as CutRotatedShell).CutRotated);
                }
            }

            circularCopyShell.CircularCopy.Create();

            return circularCopyShell;
        }


        protected ThreadShell Thread(List<I3DOperation> i3DOperations)
        {
            ThreadShell threadShell = new ThreadShell();


            threadShell.Thread = Part.NewEntity((short)Obj3dType.o3d_thread);
            threadShell.ThreadDefinition = threadShell.Thread.GetDefinition();

            threadShell.ThreadDefinition.autoDefinDr = true;
            threadShell.ThreadDefinition.allLength = true;
            //threadShell.ThreadDefinition.length = 2;

            ksEntityCollection faces = Part.EntityCollection((short)Obj3dType.o3d_face);

            for(int i = 0; i < faces.GetCount(); i++)
            {
                ksEntity face = faces.GetByIndex(i);
                ksFaceDefinition faceDefinition = face.GetDefinition();

                foreach(I3DOperation i3D in i3DOperations)
                {
                    if (i3D is CutRotatedShell)
                    {
                        if ((i3D as CutRotatedShell).CutRotated == faceDefinition.GetOwnerEntity())
                        {
                            face.Update();
                            threadShell.ThreadDefinition.SetBaseObject(face);

                            threadShell.Thread.Create();

                            break;
                        }
                        else if (i3D is BossExtrusionShell)
                        {
                            if ((i3D as BossExtrusionShell).BossExtrusion == faceDefinition.GetOwnerEntity())
                            {
                                face.Update();
                                threadShell.ThreadDefinition.SetBaseObject(face);

                                threadShell.Thread.Create();

                                break;
                            }
                        }
                    }
                }

            }

          

            return threadShell;
        }


        protected ChamferShell Chamfer(List<Point3D> points, double length, double angle)
        {
            ChamferShell chamferShell = new ChamferShell();

            chamferShell.Chamfer = Part.NewEntity((short)Obj3dType.o3d_chamfer);
            chamferShell.ChamferDefinition = chamferShell.Chamfer.GetDefinition();

            double distance1 = length;
            double distance2 = Math.Tan(angle * Math.PI / 180) * distance1;

            chamferShell.ChamferDefinition.SetChamferParam(true, distance1, distance2);
            chamferShell.ChamferDefinition.tangent = true;

            ksEntityCollection partEdges = Part.EntityCollection((short)Obj3dType.o3d_edge);

            ksEntityCollection chamferEdges = chamferShell.ChamferDefinition.array();

            chamferEdges.Clear();


            foreach (var point in points)
            {
                try
                {
                    partEdges.SelectByPoint(point.X, point.Y, point.Z);

                    chamferEdges.Add(partEdges.GetByIndex(0));
                }
                catch
                {
                    IKompasModel.Kompas.ksMessage("Не найдено ребро для построения фаски!");
                }
            }

            chamferShell.Chamfer.Create();

            return chamferShell;
        }

        public KompasDetail()
        {
            Document3D = (ksDocument3D)IKompasModel.Kompas.Document3D();
            Document3D.Create(false, true);

            Part = (ksPart)Document3D.GetPart((short)Part_Type.pTop_Part);
        }
    }
}
