using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Acopio
{
    public partial class Frm_GenBonos : DevExpress.XtraEditors.XtraForm
    {
        private static Frm_GenBonos m_FormDefInstance;
        public static Frm_GenBonos DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new Frm_GenBonos();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }
        public Frm_GenBonos()
        {
            InitializeComponent();
        }
    }
}