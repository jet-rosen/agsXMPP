using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Form02.Helpers;

namespace Form02.Global
{
    class AppInfo
    {
        static AppInfo sharedInfo;
        
        public string strDeviceType;
        public string strDeviceInfo;
        public string strDeviceToken;
        public string strDeviceName;
        public string strPushToken;

        public static AppInfo Instance()
        {
            if (sharedInfo == null)
            {
                sharedInfo = new AppInfo();

                //init
                sharedInfo.initInfo();

            }
            return sharedInfo;
        }

        private void initInfo()
        {
            strDeviceType = "3";
            strDeviceToken = DeviceHelper.getDeviceToken();
            strDeviceName = DeviceHelper.getDeviceName();
            strDeviceInfo = DeviceHelper.getDeviceInfo();



        }


    }
}
