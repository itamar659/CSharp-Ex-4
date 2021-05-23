using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public class MenuItem
    {
        public event ClickDelegate Click;

        private readonly List<MenuItem> m_MenuItems;

        public MenuItem Parent { get; private set; }
        public string Text { get; set; }

        public MenuItem()
        {
            m_MenuItems = new List<MenuItem>();
            Text = string.Empty;
        }

        public MenuItem(string i_Text) : this()
        {
            Text = i_Text;
        }

        public void AddMenuItem(MenuItem i_MenuItem)
        {
            i_MenuItem.Parent = this;
            m_MenuItems.Add(i_MenuItem);
        }

        public void RemoveMenuItem(MenuItem i_MenuItem)
        {
            i_MenuItem.Parent = null;
            m_MenuItems.Remove(i_MenuItem);
        }

        public void ClickMe(int i_Index)
        {
            m_MenuItems[i_Index].OnClick();
        }

        public bool IsValidIndex(int i_Index)
        {
            return (0 <= i_Index && i_Index < m_MenuItems.Count);
        }

        public override string ToString()
        {
            StringBuilder menuStr = new StringBuilder();

            if (m_MenuItems.Count != 0)
            {
                int currentMenuIndex = 0;

                menuStr.AppendLine(Text);
                menuStr.AppendLine("==================");

                foreach (MenuItem button in m_MenuItems)
                {
                    menuStr.AppendLine(string.Format("{0}. {1}", currentMenuIndex, button.Text));
                    currentMenuIndex++;
                }
            }
            else
            {
                menuStr.Append(Text);
            }

            return menuStr.ToString();
        }

        protected virtual void OnClick()
        {
            Click?.Invoke();
        }
    }
}
