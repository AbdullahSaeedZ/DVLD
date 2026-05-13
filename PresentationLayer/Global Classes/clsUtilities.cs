using System;


namespace PresentationLayer.Global_Classes
{
    public static class clsUtilities
    {
        public static Action OnBreadcrumbUpdate;


        private static string _breadcrumbText = "";
        public static string BreadcrumbText 
        {
            get
            {
                return _breadcrumbText;
            }
            set
            {
                _breadcrumbText = value;
                OnBreadcrumbUpdate?.Invoke();
            }
        }
        public static void AddToBreadcrumb(string text)
        {
            BreadcrumbText += " " + text; // to have space between sections shown in breadcrumb
        }
        public static void RemoveFromBreadcrumb(string text)
        {
            text = " " + text;

            int index = BreadcrumbText.IndexOf(text);
            if (!(index < 0)) // to avoid crash when index is less than 0, will happen when repeated section names removed, happened once but i removed the repetition and put this validation
                 BreadcrumbText = BreadcrumbText.Remove(index);
        }

    }
}
