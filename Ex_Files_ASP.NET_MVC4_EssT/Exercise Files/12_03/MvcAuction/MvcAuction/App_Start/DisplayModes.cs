using System;
using System.Web.WebPages;

public class DisplayModes
{
    public static void ConfigureDisplayModes()
    {
        // register iPhone-specific views
        DisplayModeProvider.Instance.Modes.Insert(0, new DefaultDisplayMode("iPhone")
        {
            ContextCondition = (ctx => ctx.Request.UserAgent.IndexOf(
            "iPhone", StringComparison.OrdinalIgnoreCase) >= 0)
        });

        // register iPad-specific views
        DisplayModeProvider.Instance.Modes.Insert(0, new DefaultDisplayMode("iPad")
        {
            ContextCondition = (ctx => ctx.Request.UserAgent.IndexOf(
            "iPad", StringComparison.OrdinalIgnoreCase) >= 0)
        });
    }
}