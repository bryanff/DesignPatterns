using DesignPatterns.Decorator.Modes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator.ModeDecorators
{
    public class LightMode : ModeDecorator
    {
        public LightMode(IMode mode) : base(mode) { }

        public override string applyMode(string username)
        {
            return $"***\x1B[4m<b>{username}</b>\x1B[0m***┬─┬ノ(º_ºノ)";
        }
    }
}
