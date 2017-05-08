using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net.Http;
using Form02.Helpers;
using Newtonsoft.Json;
using Form02.Api.ResponseModels;
using Form02.Global;

namespace Form02.Api
{
    class ApiManager
    {
        private static string TAG = "ApiManager";

        private static HttpClient client = new HttpClient();

        
        async public static Task<string> api_user_signin(string strUserId, string strPwd)
        {
            AppInfo appInfo = AppInfo.Instance();

            var p_params = new Dictionary<string, string> {
                { "s_profile", strUserId },
                { "s_pwd", strPwd },
                { "s_dev_type", appInfo.strDeviceType },
                { "s_dev_token", appInfo.strDeviceToken },
                { "s_push_token", appInfo.strPushToken },
                { "s_dev_name", appInfo.strDeviceName },
                { "s_dev_info", appInfo.strDeviceInfo }
            };

            var p_body = new FormUrlEncodedContent(p_params);
            try
            {
                var response = await client.PostAsync(ApiConstants.URL_USER_LOGIN, p_body);
                var responseString = await response.Content.ReadAsStringAsync();
                LogHelper.LogConsole(TAG, responseString);
                return responseString;
            }
            catch
            {
                return "{'code':'-1','msg':'connection error', 'data':'0'}";
            }
        }


        async public static Task<string> api_user_signup(string strName, string strProfile, string strPwd, string strType)
        {
            var p_params = new Dictionary<string, string> {
                { "s_name", strName },
                { "s_profile", strProfile },
                { "s_pwd", strPwd },
                { "s_type", strType }
            };

            var p_body = new FormUrlEncodedContent(p_params);
            try
            {
                var response = await client.PostAsync(ApiConstants.URL_USER_REGISTER, p_body);
                var responseString = await response.Content.ReadAsStringAsync();
                LogHelper.LogConsole(TAG, responseString);
                return responseString;
            }
            catch
            {
                return "{'code':'-1','msg':'connection error', 'data':'0'}";
            }
        }
        


    }
}
