using System;
using SchoolSystem.Framework.Models.Contracts;
using SchoolSystem.Framework.Models.Enums;
using SchoolSystem.Framework.Models;

namespace SchoolSystem.Framework.Core.Contracts
{
    public interface IMarkFactory
    {
        IMark CreateMark(Subject subject, float value);
    }

    //public class MarkFactory : IMarkFactory
    //{
    //    public IMark CreateMark(Subject subject, float value)
    //    {
    //        return new Mark(subject, value);
    //    }
    //}
}