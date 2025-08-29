using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace ETA25_Intermediate_C_.Session10.Interfaces;
public interface IBrowser
{
    //metoda ce ne prerminte sa intoarce un driver
    //interfata asta o sa fie implementate in mai multe clase specifice fiecarui tip de browser

    IWebDriver CreateDriver();

}
