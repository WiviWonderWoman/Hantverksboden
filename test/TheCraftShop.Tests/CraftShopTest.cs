using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using TheCraftShop.Models;
using Xunit;

namespace TheCraftShop.Tests
{
    public class CraftShopTest
    {
        //Testing if its possible to create an instance of HandicraftRepository and if it contains all handicrafts
        [Fact]
        public void AddingHandicrafts()
        {
            //Arrange: Create In Memory Database
            var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase(databaseName: "test")
            .Options;

            //Act
            using (var _appDbContext = new AppDbContext(options))
            {
                HandicraftRepository handicraftRepository = new HandicraftRepository(_appDbContext);
                var allHandicrafts = handicraftRepository.AllHandicrafts;

                List<Handicraft> _allHandicrafts = new List<Handicraft>();

                foreach (var handicraft in allHandicrafts)
                {
                    _allHandicrafts.Add(handicraft);
                }
                var expected = _allHandicrafts.Count;
                var actual = allHandicrafts.Count();

                //Assert
                Assert.NotEmpty(allHandicrafts);
                Assert.Equal(expected, actual);
            }
        }

        //Testing if its possible to create an instance of CraftMethodRepository and if it contains all craft methods
        [Fact]
        public void AddingCraftMethods()
        {
            //Arrange: Create In Memory Database
            var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase(databaseName: "test")
            .Options;

            List<CraftMethod> _craftMethods = new List<CraftMethod>();

            //Act
            using (var _appDbContext = new AppDbContext(options))
            {
                CraftMethodRepository craftMeyhodRepository = new CraftMethodRepository(_appDbContext);
                var allMethodsHandicrafts = craftMeyhodRepository.AllCraftMethods;

                foreach (var method in allMethodsHandicrafts)
                {
                    _craftMethods.Add(method);
                }
                var expected = _craftMethods.Count;

                var actual = allMethodsHandicrafts.Count();

                //Assert
                Assert.NotEmpty(allMethodsHandicrafts);
                Assert.Equal(expected, actual);
                
            }
        }

        //Testing the sorting off handicrafts by craft method
        [Fact]
        public void SortByCraftMethod()
        {
            //Arrange: Create In Memory Database
            var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase(databaseName: "test")
            .Options;

            List<Handicraft> crochetHandicrafts = new List<Handicraft>();
            List<Handicraft> macrameHandicrafts = new List<Handicraft>();
            List<Handicraft> drawnHandicrafts = new List<Handicraft>();

            //Act
            using (var _appDbContext = new AppDbContext(options))
            {
                HandicraftRepository handicraftRepository = new HandicraftRepository(_appDbContext);
                var allHandicrafts = handicraftRepository.AllHandicrafts;


                foreach (var handicraft in allHandicrafts)
                {
                    if (handicraft.CraftMethodId == 1)
                    {
                        crochetHandicrafts.Add(handicraft);
                    }
                    else if (handicraft.CraftMethodId == 2)
                    {
                        macrameHandicrafts.Add(handicraft);
                    }
                    else if (handicraft.CraftMethodId == 3)
                    {
                        drawnHandicrafts.Add(handicraft);
                    }
                }
                var crocheted = handicraftRepository.Crochet;
                var expectedCrochet = crocheted.Count();
                var actualCrochet = crochetHandicrafts.Count;

                var macramed = handicraftRepository.Macrame;
                var expectedMacrame = macramed.Count();
                var actualMacrame = macrameHandicrafts.Count;

                var drawn = handicraftRepository.Drawing;
                var expectedDrawing = drawn.Count();
                var actualDrawing = drawnHandicrafts.Count;

                //Assert
                Assert.NotEmpty(crocheted);
                Assert.Equal(expectedCrochet, actualCrochet);

                Assert.NotEmpty(macramed);
                Assert.Equal(expectedMacrame, actualMacrame);

                Assert.NotEmpty(drawn);
                Assert.Equal(expectedDrawing, actualDrawing);
            }
        }
    }
}
