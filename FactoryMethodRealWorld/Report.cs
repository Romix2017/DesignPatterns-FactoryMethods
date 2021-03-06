﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodRealWorld
{
    public class Report : Document
    {
        public override void CreatePages()
        {
            Pages.Add(new IntroductionPage());
            Pages.Add(new ResultsPage());
            Pages.Add(new ConclusionPage());
            Pages.Add(new SumaryPage());
            Pages.Add(new BibliographyPage());
        }
    }
}
