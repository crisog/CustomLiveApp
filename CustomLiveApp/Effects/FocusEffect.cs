using System;
using Xamarin.Forms;

namespace CustomLiveApp.Effects
{
    public class FocusEffect : RoutingEffect
    {
        public FocusEffect() : base($"MyCompany.{nameof(FocusEffect)}")
        {
        }
    }
}
