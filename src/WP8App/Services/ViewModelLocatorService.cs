// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   ServiceLocator.tt
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using IIoc=WPAppStudio.Ioc.Interfaces;
using Ioc=WPAppStudio.Ioc;
using IViewModels=WPAppStudio.ViewModel.Interfaces;

namespace WPAppStudio.Services
{
    /// <summary>
    /// Implementation of the ViewModel locator service based on IoC.
    /// </summary>
    [CompilerGenerated]
    [GeneratedCode("Radarc", "4.0")]
    public class ViewModelLocatorService
    {
        // IoC container
        private readonly IIoc.IContainer _container;

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewModelLocatorService" /> class.
        /// </summary>
        public ViewModelLocatorService()
        {
            _container = new Ioc.Container();
        }
		
		/// <summary>
        /// Resolve a service of type T
        /// </summary>
        /// <typeparam name="T">Type of the service.</typeparam>
        /// <returns></returns>
        public T ResolveService<T>()
        {
            return _container.Resolve<T>();
        }

        /// <summary>
        /// Gets the reference to a DogbreedsLetterA_ListViewModel.
        /// </summary>
		public IViewModels.IDogbreedsLetterA_ListViewModel DogbreedsLetterA_ListViewModel
        {
            get { return _container.Resolve<IViewModels.IDogbreedsLetterA_ListViewModel>(); }
        }

        /// <summary>
        /// Gets the reference to a DogbreedsLetterE_DetailViewModel.
        /// </summary>
		public IViewModels.IDogbreedsLetterE_DetailViewModel DogbreedsLetterE_DetailViewModel
        {
            get { return _container.Resolve<IViewModels.IDogbreedsLetterE_DetailViewModel>(); }
        }

        /// <summary>
        /// Gets the reference to a DogbreedsLetterD_DetailViewModel.
        /// </summary>
		public IViewModels.IDogbreedsLetterD_DetailViewModel DogbreedsLetterD_DetailViewModel
        {
            get { return _container.Resolve<IViewModels.IDogbreedsLetterD_DetailViewModel>(); }
        }

        /// <summary>
        /// Gets the reference to a DogbreedsLetterC_DetailViewModel.
        /// </summary>
		public IViewModels.IDogbreedsLetterC_DetailViewModel DogbreedsLetterC_DetailViewModel
        {
            get { return _container.Resolve<IViewModels.IDogbreedsLetterC_DetailViewModel>(); }
        }

        /// <summary>
        /// Gets the reference to a DogbreedsLetterB_DetailViewModel.
        /// </summary>
		public IViewModels.IDogbreedsLetterB_DetailViewModel DogbreedsLetterB_DetailViewModel
        {
            get { return _container.Resolve<IViewModels.IDogbreedsLetterB_DetailViewModel>(); }
        }

        /// <summary>
        /// Gets the reference to a DogbreedsLetterA_DetailViewModel.
        /// </summary>
		public IViewModels.IDogbreedsLetterA_DetailViewModel DogbreedsLetterA_DetailViewModel
        {
            get { return _container.Resolve<IViewModels.IDogbreedsLetterA_DetailViewModel>(); }
        }
		/// <summary>
        /// Gets the reference to a AboutViewModel.
        /// </summary>
		public IViewModels.IAboutViewModel AboutViewModel
        {
            get { return _container.Resolve<IViewModels.IAboutViewModel>(); }
        }
		
		/// <summary>
        /// Gets the reference to a LicenseViewModel.
        /// </summary>
		public IViewModels.ILicenseViewModel LicenseViewModel
        {
            get { return _container.Resolve<IViewModels.ILicenseViewModel>(); }
        }
    }
}
