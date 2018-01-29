using System;
using System.Collections.Generic;
using UnitTestSample.Domain.Contracts;

namespace UnitTestSample.Domain.FakeRepository
{
    public class BookFakeRepository : IBookRepository
    {
        public List<DateTime> GetByDate(DateTime starDate, DateTime endDate)
        {
            List<DateTime> result = new List<DateTime>();
            result.Add(starDate);

            return result;
        }
    }
}
