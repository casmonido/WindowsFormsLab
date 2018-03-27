using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp
{
    public interface RefreshableForm
    {
        //void refresh(ref List<Figura> list);
        //void refresh();

        void refreshInsert(Figura d);

        void refreshDelete(Figura d);

        void refreshModify(Figura d);
    }
}
