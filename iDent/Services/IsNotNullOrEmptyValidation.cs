using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace iDent.Services
{
    class IsNotNullOrEmptyValidation : Behavior<Entry>
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
            var value = e.NewTextValue;
            if (value == null)
            {
                isValid = false;
            }

            var str = value as string;
            isValid = !string.IsNullOrWhiteSpace(value);
        }
    }
}
