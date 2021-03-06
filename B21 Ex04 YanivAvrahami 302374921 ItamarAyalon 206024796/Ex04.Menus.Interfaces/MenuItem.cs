using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public class MenuItem
    {
        public List<MenuItem> m_MenuItems;
        public ICommand Command { get; set; }
        public MenuItem Parent { get; set; }
        public string Text { get; set; }

        public MenuItem()
        {
            m_MenuItems = new List<MenuItem>();
            Text = string.Empty;
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

        public void Click(int i_Index)
        {
            if(m_MenuItems[i_Index].Command == null)
            {
                throw new NullReferenceException("Error: MenuItem doesn't have a command!");
            }

            m_MenuItems[i_Index].Command.Execute();
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
    }
}
