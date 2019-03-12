using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace iDent.Services
{
    class EmailValidationBehavior : Behavior<Entry>
    {
        public bool isValid;

        protected override void OnAttachedTo(Entry bindable)
        {
            base.OnAttachedTo(bindable);
            bindable.TextChanged += BindableOnTextChanged;
        }

        protected override void OnDetachingFrom(Entry bindable)
        {
            base.OnDetachingFrom(bindable);
            bindable.TextChanged -= BindableOnTextChanged;
        }

        private void BindableOnTextChanged(object sender, TextChangedEventArgs e)
        {
            var email = e.NewTextValue;

            var emailEntry = sender as Entry;

            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);

            if (match.Success)
            {
                emailEntry.TextColor = Color.Black;
                isValid = true;
            }
            else
            {
                emailEntry.TextColor = Color.Red;
                isValid = false;

            }            

        }

    }
}
