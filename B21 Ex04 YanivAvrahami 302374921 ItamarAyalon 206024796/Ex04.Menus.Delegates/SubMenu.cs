namespace Ex04.Menus.Delegates
{
    public class SubMenu : MenuItem
    {
        public new event ClickMenuDelegate Click;

        public SubMenu() : base()
        {
        }

        public SubMenu(string i_Text) : base(i_Text)
        {
        }

        protected override void OnClick()
        {
            Click?.Invoke(this);
        }
    }
}
