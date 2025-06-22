using Kompas6API5;
using Kompas6Constants3D;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oil_level_glass.Kompas_classes
{
    internal class WindowAssemble : KompasAssemble
    {
        private Housing _housing;
        private Ring _ring;
        private Glass _glass;

        private ksPart _ring1Part, _ring2Part, _glassPart, _housingPart;

        private ksEntityCollection _ring1Edges, _ring2Edges, _glassEdges, _housingEdges;
        private ksEntityCollection _ring1Faces, _ring2Faces, _glassFaces, _housingFaces;
        public override void CreateAssemble()
        {
            base.CreateAssemble();


            Document3D.SetPartFromFile(_housing.SavePath,assemble,true);
            Document3D.SetPartFromFile(_glass.SavePath, assemble, true);
            Document3D.SetPartFromFile(_ring.SavePath, assemble, true);
            Document3D.SetPartFromFile(_ring.SavePath, assemble, true);

            _housingPart = Document3D.GetPart(0);
            _glassPart = Document3D.GetPart(1);
            _ring1Part = Document3D.GetPart(2);
            _ring2Part = Document3D.GetPart(3);

            _ring1Edges = _ring1Part.EntityCollection((short)Obj3dType.o3d_edge);
            _ring2Edges = _ring2Part.EntityCollection((short)Obj3dType.o3d_edge);
            _glassEdges = _glassPart.EntityCollection((short)Obj3dType.o3d_edge);
            _housingEdges = _housingPart.EntityCollection((short)Obj3dType.o3d_edge);

         

            _ring1Faces = _ring1Part.EntityCollection((short)Obj3dType.o3d_face);
            _ring2Faces = _ring2Part.EntityCollection((short)Obj3dType.o3d_face);
            _glassFaces = _glassPart.EntityCollection((short)Obj3dType.o3d_face);
            _housingFaces = _housingPart.EntityCollection((short)Obj3dType.o3d_face);



            Document3D.AddMateConstraint(4, _ring1Edges.GetByIndex(_ring.ConstraintEdgeIndex), _ring2Edges.GetByIndex(_ring.ConstraintEdgeIndex), 0, -1, 0);
            Document3D.AddMateConstraint(4, _ring1Edges.GetByIndex(_ring.ConstraintEdgeIndex), _glassEdges.GetByIndex(_glass.ConstraintEdgeIndex), 0, -1, 0);

            _ring1Faces.SelectByPoint(_ring.ConstraintFacePoint.X,_ring.ConstraintFacePoint.Y,_ring.ConstraintFacePoint.Z);
            _ring2Faces.SelectByPoint(_ring.ConstraintFacePoint.X, _ring.ConstraintFacePoint.Y, _ring.ConstraintFacePoint.Z);
            _glassFaces.SelectByPoint(_glass.ConstraintTopFacePoint.X, _glass.ConstraintTopFacePoint.Y, _glass.ConstraintTopFacePoint.Z);

            Document3D.AddMateConstraint(0,_ring1Faces.First(),_glassFaces.First() , -1, 1, 0);

            _glassFaces = _glassPart.EntityCollection((short)Obj3dType.o3d_face);
            _glassFaces.SelectByPoint(_glass.ConstraintBottomFacePoint.X, _glass.ConstraintBottomFacePoint.Y, _glass.ConstraintBottomFacePoint.Z);

            Document3D.AddMateConstraint(0, _glassFaces.First(), _ring2Faces.First(), -1,1,0);

            _housingEdges.SelectByPoint(_housing.ConstraintFacePoint.X,_housing.ConstraintFacePoint.Y,_housing.ConstraintFacePoint.Z);

            _glassEdges.SelectByPoint(_glass.ConstraintTopFacePoint.X, _glass.ConstraintTopFacePoint.Y, _glass.ConstraintTopFacePoint.Z);

            Document3D.AddMateConstraint(4,_housingEdges.First(),_glassEdges.First(),-1,1,0);

            _housingFaces = _housingPart.EntityCollection((short)Obj3dType.o3d_face);
            _housingFaces.SelectByPoint(_housing.ConstraintFacePoint3.X,_housing.ConstraintFacePoint3.Y,_housing.ConstraintFacePoint3.Z);


            _housingEdges.SelectByPoint(_housing.ConstraintFacePoint.X, _housing.ConstraintFacePoint.Y, _housing.ConstraintFacePoint.Z);


            _ring2Faces = _ring2Part.EntityCollection((short)Obj3dType.o3d_face);
            _ring2Faces.SelectByPoint(_ring.ConstraintEdgePoint2.X,_ring.ConstraintEdgePoint2.Y,_ring.ConstraintEdgePoint2.Z);

            Document3D.AddMateConstraint(0,_housingFaces.First(),_ring2Faces.First(),-1,1, 0);

            Document3D.RebuildDocument();
        }

        public WindowAssemble(Housing housing, Ring ring,  Glass glass)
        {
            _housing = housing;

            _ring = ring;

            _glass = glass;
        }
    }
}
