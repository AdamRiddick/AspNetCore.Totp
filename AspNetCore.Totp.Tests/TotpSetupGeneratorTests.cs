using Xunit;

namespace AspNetCore.Totp.Tests
{
    public class TotpSetupGeneratorTests
    {
        private readonly TotpSetupGenerator totpSetupGenerator;
        public TotpSetupGeneratorTests()
        {
            this.totpSetupGenerator = new TotpSetupGenerator();
        }

        [Fact]
        public void GenerateSetupCode_shouldNotBeNull_manuelTest_workWithGoogleAuthenticator()
        {
            var totpSetup = this.totpSetupGenerator.Generate("Super Totp Tester", "Damir Kusar", "7FF3F52B-2BE1-41DF-80DE-04D32171F8A3", 1);
            Assert.NotNull(totpSetup);
            Assert.Equal("G5DEMM2GGUZEELJSIJCTCLJUGFCEMLJYGBCEKLJQGRCDGMRRG4YUMOCBGM", totpSetup.ManualSetupKey);
            Assert.Equal("data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAEEAAABBCAYAAACO98lFAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsMAAA7DAcdvqGQAAATzSURBVHhe7ZDRiuRADAP3/396Loapo1DLmezjcVNgbEtqB/Lz+vL6/oSL70+4+P6Ei+Mn/Pz8rAVtdwdyWXhgPdm89n7TspJDaaEB3Z0yqX/y4W53njl3ZvBsmn4oPkix05kh98FaezOgpc9uDVou5yF178mhPH1sn2qgt061fWja0LTBGjNZ78mhPH3ccpSx5sxW5KD5Cbp9axR7cigtNFj3Qc/0Nieptzc5A/rmD7lD0w+Fw63w/5W+VXIqD+BQPShv85t3t6cH6Jv/lPp6jlLeIfehZeieAd0F2+4yTUvuMrcvPx3HI5c7eE7usngtk9rQtMH56r/7XzKUj+2nRq7taIPn4UkuvQHNhd764BkOpR3YZtNyrk2n8OmbN1gf2LdM6smpXPgA3B0kv3mNzG55POtNg9/qQ1V/c4i96elZg8xtuwuaNmw55uRQ8gC0Q85Z+zQP1hupb/nZ7bXC2zgcPxzudmb7g/ec7/LZh5Yfmo5mPTV7cCpv8qEfb7rBc7Zhv83QfGuw6XccST9uB62huzMP6Q9kXOjQfLDmDFrjU259STgPuPDBc7LlZmbf+uDc0Lwt0zxzqC2Y2nY0tTaT2XIm3+Q8WHcfyKaWHAqh1jdvyFwWeAZn3DOLlt6TnOekq2/y0HA3ex+a75znoe1bp8ymD02Dw/ER91Z49NQMvjPeh9TsDVt2K+fuONwnj4bMeGdOjQJrqSctZ9r7zK9v373CEVfqkB4zPedWcKcbdmetPeVI+ohrw96WbZnMtYzn1FoHspS1RleFj+Uh5tQhs855d8GT2aBPz0LfOByHfQR8NGdr4P1J7olnf8tCe5Mcjh/kTGeGlnEfZs5Cp7d5sA5k7OVOz0pO5cLBfORjzaNnoYPnIb32Zmj7p/zmQVcFR1qlb7zn/KnIuQ+ejbOfqlHVLWx8ND/wW32wZg/dPrBbt7blk0NtQQ7i5ZydecjZOXrLpD7c6ZA+u7VkdfywdWbIzEBu01JP0LIPLT+MTkHuyerwiAMuYLbOzD5sXtOzYNtToz/R4VREfVC0IT/wZG+Qw99mQHNZZ3ZPDjWPtIKmDdZd6bEbe8OW22hvYfZ251AIZR+2eZidSqy3nhp4b/nB+zZD04ZTEX7AAR/KbjLnahqFZ+wN7C7wPKTfqC6PPj5ePri9s5eZ9FrOM7Rs5shQyalcEMzH6OCd2dmtWs4aM93VtCwydObBM5zKBQ9dkFrz6VlNN5nZZu/0Ox08m65e5IM8TFkD6+5DZsH61o3zg7OZt9fo6hsO3h1tmdyHu53Z71JzWWemMzc2f3/xxh9wH5o25D6Mlm9TGzaNbq/NmUmat6cvfBjqkUvLSqy3zmzQ7aXWvJwHdmtwKIS2A6nTU2/1iS2Hhu9MemDd5D4cCsdciTVnMmsP0FywzYCWXnvn3mZzKgt5bOvMw93O/LR40/pgLQt9Y3cW8nAe33xm78Z78/wuZ/bB83DnwaFytBUwWxu2vfU7j06x01NnHqy33jicLdyOOuudeSsyJn14mhua7nx6cKgE86EPeB5yH5oG491VgpZevvF+V8mhEMpH2QdrWejQdLT0codNoyC17Mmh+gHFTt+09HK21mi5bU+cS79p5nC2MLoPOotubcjM1l1PyLcGzQWe4VDysSuxvuVSd3/itX1oszPb3Nid/4jvT7j4/oSL7094vV5/AGswn+f1xzrgAAAAAElFTkSuQmCC", totpSetup.QrCodeImage);
        }
    }
}