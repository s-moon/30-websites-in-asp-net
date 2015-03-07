﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace W4_JonSkeetQuote
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            QuoteEngine qe = new QuoteEngine(Server.MapPath(QuoteEngine.QUOTE_PATH));

            theQuoteLabel.Text = qe.GetRandomQuote();
        }
    }
}