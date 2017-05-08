using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Form02.Global;
using PhoneNumbers;

namespace Form02.Helpers
{
    class EmailPhoneHelper
    {

        public static string getProfileType(string strProfile)
        {
            try
            {
                var phoneUtil = PhoneNumberUtil.GetInstance();
                var number = phoneUtil.Parse(strProfile, "");
                if (phoneUtil.IsValidNumber(number))
                {
                    return Constants.PROFILE_PHONE;
                }                
            }
            catch
            {
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(strProfile);
                if (addr.Address == strProfile)
                {
                    return Constants.PROFILE_EMAIL;
                }

            }
            catch
            {
            }
            return Constants.PROFILE_NONE;
        }
    }
}
