namespace Ex04.Menus.Delegates
{
    public class SubMenu : MenuItem
    {
        public new event ClickMenuDelegate Click;

        protected override void OnClick()
        {
            Click?.Invoke(this);
        }
    }
}
