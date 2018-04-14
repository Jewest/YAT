using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YAT.View
{
    class AskController
    {
        Form m_parentView;

        public AskController(Form parentView)
        {
            m_parentView = parentView;
        }

        string GetNewName(string oldName)
        {
            string newName = "";

            frmAsk view = new frmAsk();

            view.ShowDialog(m_parentView);



            return newName;
        }
    }
}
