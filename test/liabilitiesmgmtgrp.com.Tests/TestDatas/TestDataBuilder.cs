using liabilitiesmgmtgrp.com.EntityFrameworkCore;

namespace liabilitiesmgmtgrp.com.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly comDbContext _context;

        public TestDataBuilder(comDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            //create test data here...
        }
    }
}