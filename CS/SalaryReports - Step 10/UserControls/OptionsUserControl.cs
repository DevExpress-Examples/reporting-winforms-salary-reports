using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Helpers;

namespace SalaryReports.UserControls
{
    public partial class OptionsUserControl : DevExpress.XtraEditors.XtraUserControl
    {
        public OptionsUserControl()
        {
            InitializeComponent();
            SkinHelper.InitSkinGallery(galleryControl1);
        }
    }
}
