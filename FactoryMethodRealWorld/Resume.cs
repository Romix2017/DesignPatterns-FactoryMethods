﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodRealWorld
{
    public class Resume : Document
    {
        public override void CreatePages()
        {
            Pages.Add(new SkillsPage());
            Pages.Add(new EducationPage());
            Pages.Add(new ExperiencePage());
        }
    }
}