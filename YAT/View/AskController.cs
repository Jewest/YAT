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

        public string GetNewName(string oldName)
        {
            frmAsk view = new frmAsk();
            view.SetDescriptionText("Please insert the new desired name:");
            view.SetText(oldName);
            view.ShowDialog(m_parentView);

            string result = view.GetResult();

            if(result == null)
            {
                result = "";
            }

            return result;
        }
    }
}
