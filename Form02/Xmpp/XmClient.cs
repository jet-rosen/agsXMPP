using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using agsXMPP;
using agsXMPP.protocol;
using agsXMPP.protocol.client;
using Form02.Helpers;
using agsXMPP.Xml.Dom;

namespace Form02.Xmpp
{
    class XmClient
    {
        static string TAG = "XMCLIENT";

        public static XmClient sharedClient;

        XmppClientConnection xmppConn;

        string serverdomain = "pig.com";
        string serverip = "192.168.1.140";

        public string user_jid { get; set; }
        public string user_jpwd { get; set; }
        

        public static XmClient Instance()
        {
            if (sharedClient == null)
            {
                sharedClient = new XmClient();
            }
            return sharedClient;
        }

        XmClient()
        {
            xmppConn = new XmppClientConnection(serverdomain);

            initXmppClient();
        }

        void initXmppClient()
        {
            try
            {
                xmppConn.Server = serverdomain;
                xmppConn.ConnectServer = serverip;
                xmppConn.Port = 5222;
                xmppConn.Resource = "pc_win";
                xmppConn.AutoResolveConnectServer = false;

                xmppConn.OnRosterStart += new ObjectHandler(xmppCon_OnRosterStart);
                xmppConn.OnRosterItem += new XmppClientConnection.RosterHandler(xmppCon_OnRosterItem);
                xmppConn.OnRosterEnd += new ObjectHandler(xmppCon_OnRosterEnd);
                xmppConn.OnPresence += new PresenceHandler(xmppCon_OnPresence);
                xmppConn.OnMessage += new MessageHandler(xmppCon_OnMessage);
                xmppConn.OnLogin += new ObjectHandler(xmppCon_OnLogin);
            }
            catch (Exception e)
            {
                LogHelper.LogConsole(TAG, ">>> Exception >>> " + e.Message);
            }

            
        }

        public void ConnectXm(string jid, string jpwd)
        {
            jid = "t3@pig.com";
            jpwd = "t3";

            user_jid = jid;
            user_jpwd = jpwd;
            
            try
            {              
                Jid xmid = new Jid(user_jid);
                LogHelper.LogConsole(TAG, "user login to xmpp  " + xmid.User + " " + user_jpwd + " " + xmid.Server);

                xmppConn.OnAuthError += delegate (object o, Element e) { System.Console.WriteLine(string.Format("authentication error for {0} : {1}", xmppConn.MyJID, e.ToString())); };
                //xmpp.ClientSocket.OnValidateCertificate += CertificateValidationCallBack;
                //xmppConn.ClientSocket.OnConnect += delegate (object o) { System.Console.WriteLine(" ++++ Socket Connected +++++ "); };
                //xmppConn.ClientSocket.OnDisconnect += delegate (object o) { System.Console.WriteLine(" --- Socket Disconnected --- "); };
                //xmppConn.ClientSocket.OnError += delegate (object o, Exception ex) { Console.WriteLine("ClientSocket.OnError hit, exception: " + ex.ToString()); };
                xmppConn.OnWriteXml += (_, xml) => System.Console.WriteLine(">>" + System.Environment.NewLine + xml + System.Environment.NewLine + ">>>" + System.Environment.NewLine);
                xmppConn.OnReadXml += (_, xml) => System.Console.WriteLine("<<" + System.Environment.NewLine + xml + System.Environment.NewLine + "<<<" + System.Environment.NewLine);
                //xmppConn.OnReadSocketData += (_, data, count) => System.Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<<<< " + System.Environment.NewLine + data + System.Environment.NewLine + "<<<<<<<<<<<<<<<<<<<<<<<<<<<<<< " + System.Environment.NewLine);
                //xmppConn.OnWriteSocketData += (_, data, count) => System.Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>> " + System.Environment.NewLine + data + System.Environment.NewLine + ">>>>>>>>>>>>>>>>>>>>>>>>>>>>>> " + System.Environment.NewLine);
                
                xmppConn.Open(xmid.User, user_jpwd);  
            }
            catch(Exception e)
            {
                LogHelper.LogConsole(TAG, ">>> Exception >>> " + e.Message);
            }
            
        }
        
        private void xmppCon_OnLogin(object sender)
        {
            LogHelper.LogConsole(TAG, " !!! --- !!! Logged in to server");

            xmppConn.Send(new Message(new Jid("t2@pig.com"), MessageType.chat, "from my window app"));

            xmppConn.Show = ShowType.chat;
            xmppConn.Status = "Hello";
            xmppConn.SendMyPresence();

        }

        static void xmppCon_OnRosterEnd(object sender)
        {
            //_bWait = false;
            Console.WriteLine();
            LogHelper.LogConsole(TAG, "All contacts received");
        }

        static void xmppCon_OnRosterItem(object sender, agsXMPP.protocol.iq.roster.RosterItem item)
        {
            LogHelper.LogConsole(TAG, String.Format("Got contact: {0}", item.Jid));
        }

        static void xmppCon_OnRosterStart(object sender)
        {
            LogHelper.LogConsole(TAG, "Getting contacts now");
        }

        static void xmppCon_OnPresence(object sender, Presence pres)
        {
            LogHelper.LogConsole(TAG, String.Format("Got presence from: {0}", pres.From.ToString()));
            LogHelper.LogConsole(TAG, String.Format("type: {0}", pres.Type.ToString()));
            LogHelper.LogConsole(TAG,  String.Format("status: {0}", pres.Status));
            LogHelper.LogConsole(TAG, "");
        }

        static void xmppCon_OnMessage(object sender, Message msg)
        {
            if (msg.Body != null)
            {
                LogHelper.LogConsole(String.Format("Got message from: {0}", msg.From.ToString()));
                LogHelper.LogConsole("message: " + msg.Body);
                LogHelper.LogConsole("");
            }
        }
    }
}
