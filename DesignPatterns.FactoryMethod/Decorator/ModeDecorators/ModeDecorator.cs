using DesignPatterns.Decorator.Modes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator.ModeDecorators
{
    public abstract class ModeDecorator : IMode
    {
        protected readonly IMode _mode;
        public ModeDecorator(IMode mode) => this._mode = mode;
        public abstract string applyMode(string username);
    }
}
