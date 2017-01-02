using JuliusSweetland.OptiKey.Services;
using JuliusSweetland.OptiKey.UI.ViewModels.Management;
using Moq;

namespace JuliusSweetland.OptiKey.UnitTests.UI.ViewModels.Management.DictionaryViewModelSpecifications
{
    public abstract class DictionaryViewModelTestBase : TestBase
    {
        protected DictionaryViewModel DictionaryViewModel { get; set; }
        protected Mock<IDictionaryService> DictionaryService { get; private set; }

        protected virtual bool ShouldConstruct => true;

        protected override void Arrange()
        {
            DictionaryService = new Mock<IDictionaryService>();

            if (ShouldConstruct)
            {
                DictionaryViewModel = new DictionaryViewModel(DictionaryService.Object);
            }
        }
    }
}
