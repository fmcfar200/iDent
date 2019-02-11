using Plugin.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace iDent.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactPage : ContentPage
    {
        public ContactPage()
        {
            InitializeComponent();
        }

        void OnSubmitButtonClicked(object sender, EventArgs args)
        {
            /*
            IEmailTask emailMessenger = CrossMessaging.Current.EmailMessenger;
            if (emailMessenger.CanSendEmail)
            {
                // Send simple e-mail to single receiver without attachments, bcc, cc etc.
                emailMessenger.SendEmail("frasermcfarlane1996@gmail.com", "Xamarin Messaging Plugin", "Well hello there from Xam.Messaging.Plugin");

                // Alternatively use EmailBuilder fluent interface to construct more complex e-mail with multiple recipients, bcc, attachments etc.
                /*
                var email = new EmailMessageBuilder()
                  .To("to.plugins@xamarin.com")
                  .Cc("cc.plugins@xamarin.com")
                  .Bcc(new[] { "bcc1.plugins@xamarin.com", "bcc2.plugins@xamarin.com" })
                  .Subject("Xamarin Messaging Plugin")
                  .Body("Well hello there from Xam.Messaging.Plugin")
                  .Build();

                 emailMessenger.SendEmail(email);
              */
        }
    }
} 
