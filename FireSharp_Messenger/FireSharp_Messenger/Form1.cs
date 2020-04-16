using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;

namespace FireSharp_Messenger
{
    public partial class Form1 : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "9fzElmrbSBBIgAkGWTGJuQpO0Fqw83P2rLPgyKSW",
            BasePath = "https://csharp-chat-a8cbd.firebaseio.com/"
        };
        IFirebaseClient client;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(config);
                Console.WriteLine("[YES] - Firebase Connection.");
            }
            catch (Exception)
            {
                Console.WriteLine("[NO] - Firebase Connection.");
            }
        }
    }
}
