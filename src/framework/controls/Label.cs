using System.Collections.ObjectModel;
using System.Drawing;
using OpenQA.Selenium;

namespace Project.src.framework.controls;

public class Label : BaseElement
{
    public Label(IWebElement webElement) : base(webElement)
    {
    }
}