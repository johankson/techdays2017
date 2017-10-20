using System;

using Xamarin.Forms;

namespace demo.Behaviors
{
    public class SocialSecurityNumberBehavior : Behavior<Entry>
    {
        protected override void OnAttachedTo(Entry entry)
        {
            base.OnAttachedTo(entry);

            entry.TextChanged += Entry_TextChanged;
        }

        protected override void OnDetachingFrom(Entry entry)
        {
            base.OnDetachingFrom(entry);

            entry.TextChanged -= Entry_TextChanged;
        }

        void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            var entry = (Entry)sender;

            entry.BackgroundColor = Color.Red;
            entry.TextColor = Color.White;

            if(e.NewTextValue.Length == 13)
            {
                entry.BackgroundColor = Color.Green;
                entry.TextColor = Color.White;
            }

            if(e?.OldTextValue?.Length == 13 && e.NewTextValue.Length > e.OldTextValue.Length)
            {
                entry.Text = e.OldTextValue;

                return;
            }



            if(e.NewTextValue.Length == 2 && e.NewTextValue.Length > e.OldTextValue.Length)
            {
                int number = 0;
                int.TryParse(e.NewTextValue, out number);

                if(number > DateTime.Now.Year - 2000)
                {
                    entry.Text = "19" + number;
                }
                else
                {
                    entry.Text = "20" + number;
                }
            }

            if(e.NewTextValue.Length == 8)
            {
                entry.Text += "-";
            }
        }

        private string AsString(int number)
        {
            if (number < 10)
                return "0" + number;

            return number.ToString();
        }
    }
}

