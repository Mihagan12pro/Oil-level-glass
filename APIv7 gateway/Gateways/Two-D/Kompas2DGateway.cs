using KompasAPI7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIv7_gateway.Gateways.Two_D
{
    public class Kompas2DGateway : KompasGateway
    {
        protected IViewsAndLayersManager viewsAndLayersManager; /*= document2D.ViewsAndLayersManager;*/

        protected IView view;

        public Kompas2DGateway(IKompasDocument2D? document2D)
        {
            kompasDocument = document2D;

            if (document2D == null)
                throw new NullReferenceException();

            viewsAndLayersManager = document2D.ViewsAndLayersManager;

            view = viewsAndLayersManager.Views.ActiveView;
        }
    }
}
