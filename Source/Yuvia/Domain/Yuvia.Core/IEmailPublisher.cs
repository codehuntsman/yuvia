﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yuvia.Core
{
    public interface IEmailPublisher
    {
        void Send( Email email );
    }
}