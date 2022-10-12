using System;
using System.Collections.Generic;
using System.Text;

namespace KSBlazor.Components
{
    public enum ButtonSize
    {
        [Style("")]
        Normal,
        [Style("xs")]
        ExtraSmall,
        [Style("sm")]
        Small,
        [Style("md")]
        Medium,
        [Style("lg")]
        Large,
        [Style("xl")]
        ExtraLarge,
        [Style("flat")]
        Flat
    }
}
