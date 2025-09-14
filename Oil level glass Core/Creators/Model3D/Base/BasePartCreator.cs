using APIv7_gateway.Gateways.Three_D;
using APIv7_gateway.Gateways.Two_D;
using KompasAPI7;
using Oil_level_glass_Core.Data.ModelProperties;
using Oil_level_glass_Core.Data.ModelProperties.Properties3D;
using Oil_level_glass_Core.Interfaces;
using Oil_level_glass_Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oil_level_glass_Core.Creators.Model3D.Base
{
    public abstract record BasePartCreator : BaseCreator<ModelPartProperties>, IKompas7Object
    {
        public KompasPartGateway? KompasPartGateway { get; protected set; }
       
        protected Geometry2DGateway? geometry2DGateway;

        public IApplication Application { get; init; }


        public override void SaveModel()
        {
            if (KompasPartGateway == null || Properties == null || Properties.KompasFile == null)
                throw new NullReferenceException();

            KompasPartGateway.Save(Properties?.KompasFile.FullName);
        }



        protected void SetNamingParameters()
        {
            if (KompasPartGateway == null || Properties == null || Properties.KompasFile == null)
                throw new NullReferenceException();

            KompasPartGateway.SetName(Properties.KompasFile.Name.Naming, Properties?.KompasFile.Name.Marking);
        }


        protected void SetColorParameters()
        {
            if (KompasPartGateway == null || Properties == null)
                throw new NullReferenceException();

            KompasPartGateway.SetAppearance(Properties.Appearance.RGB.GetColor(), Properties.Appearance.Ambient, Properties.Appearance.Diffuse,
                Properties.Appearance.Specularity,
                Properties.Appearance.Shininess, Properties.Appearance.Transparency, Properties.Appearance.Emission);
        }


        protected void SetMaterialParameters()
        {
            if (KompasPartGateway == null || Properties == null)
                throw new NullReferenceException();


            KompasPartGateway.SetMaterial(Properties.Material.Tittle, Properties.Material.Density, Properties.Material.HatchStyle);
        }




        public BasePartCreator()
        {
            Application = (IApplication)COMConnector.GetInstance("KOMPAS.Application.7");
        }
    }
}
