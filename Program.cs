using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net.Sockets;
using System.Net;
using Renci.SshNet;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace PeersAndRegistry {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GetCredentials());
            Console.WriteLine("Starting...");
            //List<int> extArray = new List<int>(); // list of extensions to check





            // get connection info from form

            //ConnectionInfo coninf = new ConnectionInfo("thevoipcentrepbx.co.uk", 9522, "root",
            //    new AuthenticationMethod[] {
            //        new PasswordAuthenticationMethod("root", "Fr4nkZ4pp4PBX!")
            //    });


            //using (var sshclient = new SshClient(coninf)) {
            //    try {
            //        sshclient.Connect();
            //        Console.WriteLine("Connected!");
            //    }
            //    catch {
            //        Console.WriteLine("Could not connect, check creds");
            //    }
                
            //    using (var cmd = sshclient.CreateCommand("asterisk -rx 'database show' | grep cidnum")) {
            //        cmd.Execute();
            //        //Console.WriteLine("Command> " + cmd.CommandText);
            //        // Console.WriteLine("Return Vaule = {0}", cmd.ExitStatus);
            //        String output = cmd.Result.ToString();
            //        //Console.WriteLine(output);

                    
                    
                    
            //        using (StringReader reader = new StringReader(output)) {
            //            Regex rx = new Regex(@"\d{3,6}");
            //            string line;
            //            while ((line = reader.ReadLine()) != null) {
            //                //Console.WriteLine(line);
            //                Match match = rx.Match(line);
            //                //Console.WriteLine(match.Value);
            //                extArray.Add(int.Parse(match.Value));
                            
            //            }
            //        }

                    
        

            //    }

            //    for (int i = 0; i < extArray.Count; i++) {
            //        Console.WriteLine("Checking >>" + extArray[i]);
            //        using (var cmd2 = sshclient.CreateCommand("asterisk -rx 'sip show peer " + extArray[i] + "' | grep Status")) {
            //            cmd2.Execute();
            //            //Console.WriteLine("Command> " + cmd2.CommandText);
            //            //Console.WriteLine("Return Vaule = {0}", cmd2.ExitStatus);
            //            String output = cmd2.Result.ToString();
            //            Console.WriteLine(output);

            //        }
            //    }

                

            //        sshclient.Disconnect();
            //    Console.ReadLine();
            //}
        }

    }
}
