using System;
using DevExpress.XtraSplashScreen;

namespace SaleManager.Man_Hinh_Loading
{
    public partial class ManHinhKhoiDong : SplashScreen
    {
        public ManHinhKhoiDong()
        {
            InitializeComponent();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }
    }
}