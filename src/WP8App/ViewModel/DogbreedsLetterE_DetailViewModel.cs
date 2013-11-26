// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   ViewModel.tt
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using Controls=WPAppStudio.Controls;
using Entities=WPAppStudio.Entities;
using EntitiesBase=WPAppStudio.Entities.Base;
using IServices=WPAppStudio.Services.Interfaces;
using IViewModels=WPAppStudio.ViewModel.Interfaces;
using Localization=WPAppStudio.Localization;
using Repositories=WPAppStudio.Repositories;
using Services=WPAppStudio.Services;
using ViewModelsBase=WPAppStudio.ViewModel.Base;
using WPAppStudio;
using WPAppStudio.Shared;

namespace WPAppStudio.ViewModel
{
    /// <summary>
    /// Implementation of DogbreedsLetterE_Detail ViewModel.
    /// </summary>
    [CompilerGenerated]
    [GeneratedCode("Radarc", "4.0")]
    public partial class DogbreedsLetterE_DetailViewModel : ViewModelsBase.VMBase, IViewModels.IDogbreedsLetterE_DetailViewModel, ViewModelsBase.INavigable
    {       

		private readonly Repositories.DogbreedsLetterE_DogbreedsLetterE _dogbreedsLetterE_DogbreedsLetterE;
		private readonly IServices.IDialogService _dialogService;
		private readonly IServices.INavigationService _navigationService;
		private readonly IServices.ISpeechService _speechService;
		private readonly IServices.IShareService _shareService;
		private readonly IServices.ILiveTileService _liveTileService;
		
        /// <summary>
        /// Initializes a new instance of the <see cref="DogbreedsLetterE_DetailViewModel" /> class.
        /// </summary>
        /// <param name="dogbreedsLetterE_DogbreedsLetterE">The Dogbreeds Letter E_ Dogbreeds Letter E.</param>
        /// <param name="dialogService">The Dialog Service.</param>
        /// <param name="navigationService">The Navigation Service.</param>
        /// <param name="speechService">The Speech Service.</param>
        /// <param name="shareService">The Share Service.</param>
        /// <param name="liveTileService">The Live Tile Service.</param>
        public DogbreedsLetterE_DetailViewModel(Repositories.DogbreedsLetterE_DogbreedsLetterE dogbreedsLetterE_DogbreedsLetterE, IServices.IDialogService dialogService, IServices.INavigationService navigationService, IServices.ISpeechService speechService, IServices.IShareService shareService, IServices.ILiveTileService liveTileService)
        {
			_dogbreedsLetterE_DogbreedsLetterE = dogbreedsLetterE_DogbreedsLetterE;
			_dialogService = dialogService;
			_navigationService = navigationService;
			_speechService = speechService;
			_shareService = shareService;
			_liveTileService = liveTileService;
        }
		
	
		private Entities.DogbreedsLetterESchema _currentDogbreedsLetterESchema;

        /// <summary>
        /// CurrentDogbreedsLetterESchema property.
        /// </summary>		
        public Entities.DogbreedsLetterESchema CurrentDogbreedsLetterESchema
        {
            get
            {
				return _currentDogbreedsLetterESchema;
            }
            set
            {
                SetProperty(ref _currentDogbreedsLetterESchema, value);
            }
        }
	
		private bool _hasNextpanoramaDogbreedsLetterE_Detail0;

        /// <summary>
        /// HasNextpanoramaDogbreedsLetterE_Detail0 property.
        /// </summary>		
        public bool HasNextpanoramaDogbreedsLetterE_Detail0
        {
            get
            {
				return _hasNextpanoramaDogbreedsLetterE_Detail0;
            }
            set
            {
                SetProperty(ref _hasNextpanoramaDogbreedsLetterE_Detail0, value);
            }
        }
	
		private bool _hasPreviouspanoramaDogbreedsLetterE_Detail0;

        /// <summary>
        /// HasPreviouspanoramaDogbreedsLetterE_Detail0 property.
        /// </summary>		
        public bool HasPreviouspanoramaDogbreedsLetterE_Detail0
        {
            get
            {
				return _hasPreviouspanoramaDogbreedsLetterE_Detail0;
            }
            set
            {
                SetProperty(ref _hasPreviouspanoramaDogbreedsLetterE_Detail0, value);
            }
        }

        /// <summary>
        /// Delegate method for the TextToSpeechDogbreedsLetterE_DetailStaticControlCommand command.
        /// </summary>
        public  void TextToSpeechDogbreedsLetterE_DetailStaticControlCommandDelegate() 
        {
				_speechService.TextToSpeech(CurrentDogbreedsLetterESchema.Subtitle + " " + CurrentDogbreedsLetterESchema.Description);
        }
		

        private ICommand _textToSpeechDogbreedsLetterE_DetailStaticControlCommand;

        /// <summary>
        /// Gets the TextToSpeechDogbreedsLetterE_DetailStaticControlCommand command.
        /// </summary>
        public ICommand TextToSpeechDogbreedsLetterE_DetailStaticControlCommand
        {
            get { return _textToSpeechDogbreedsLetterE_DetailStaticControlCommand = _textToSpeechDogbreedsLetterE_DetailStaticControlCommand ?? new ViewModelsBase.DelegateCommand(TextToSpeechDogbreedsLetterE_DetailStaticControlCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the ShareDogbreedsLetterE_DetailStaticControlCommand command.
        /// </summary>
        public  void ShareDogbreedsLetterE_DetailStaticControlCommandDelegate() 
        {
				_shareService.Share(CurrentDogbreedsLetterESchema.Subtitle, CurrentDogbreedsLetterESchema.Description, "", CurrentDogbreedsLetterESchema.Image);
        }
		

        private ICommand _shareDogbreedsLetterE_DetailStaticControlCommand;

        /// <summary>
        /// Gets the ShareDogbreedsLetterE_DetailStaticControlCommand command.
        /// </summary>
        public ICommand ShareDogbreedsLetterE_DetailStaticControlCommand
        {
            get { return _shareDogbreedsLetterE_DetailStaticControlCommand = _shareDogbreedsLetterE_DetailStaticControlCommand ?? new ViewModelsBase.DelegateCommand(ShareDogbreedsLetterE_DetailStaticControlCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the PinToStartDogbreedsLetterE_DetailStaticControlCommand command.
        /// </summary>
        public  void PinToStartDogbreedsLetterE_DetailStaticControlCommandDelegate() 
        {
				_liveTileService.PinToStart(typeof(IViewModels.IDogbreedsLetterE_DetailViewModel), CreateTileInfoDogbreedsLetterE_DetailStaticControl());
        }
		

        private ICommand _pinToStartDogbreedsLetterE_DetailStaticControlCommand;

        /// <summary>
        /// Gets the PinToStartDogbreedsLetterE_DetailStaticControlCommand command.
        /// </summary>
        public ICommand PinToStartDogbreedsLetterE_DetailStaticControlCommand
        {
            get { return _pinToStartDogbreedsLetterE_DetailStaticControlCommand = _pinToStartDogbreedsLetterE_DetailStaticControlCommand ?? new ViewModelsBase.DelegateCommand(PinToStartDogbreedsLetterE_DetailStaticControlCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the NextpanoramaDogbreedsLetterE_Detail0 command.
        /// </summary>
        public  void NextpanoramaDogbreedsLetterE_Detail0Delegate() 
        {
			var next =  _dogbreedsLetterE_DogbreedsLetterE.Next(CurrentDogbreedsLetterESchema);

			if(next != null)
				CurrentDogbreedsLetterESchema = next;

			RefreshHasPrevNext();
        }
		

        private ICommand _nextpanoramaDogbreedsLetterE_Detail0;

        /// <summary>
        /// Gets the NextpanoramaDogbreedsLetterE_Detail0 command.
        /// </summary>
        public ICommand NextpanoramaDogbreedsLetterE_Detail0
        {
            get { return _nextpanoramaDogbreedsLetterE_Detail0 = _nextpanoramaDogbreedsLetterE_Detail0 ?? new ViewModelsBase.DelegateCommand(NextpanoramaDogbreedsLetterE_Detail0Delegate); }
        }

        /// <summary>
        /// Delegate method for the PreviouspanoramaDogbreedsLetterE_Detail0 command.
        /// </summary>
        public  void PreviouspanoramaDogbreedsLetterE_Detail0Delegate() 
        {
			var prev =  _dogbreedsLetterE_DogbreedsLetterE.Previous(CurrentDogbreedsLetterESchema);

			if(prev != null)
				CurrentDogbreedsLetterESchema = prev;

			RefreshHasPrevNext();
        }
		

        private ICommand _previouspanoramaDogbreedsLetterE_Detail0;

        /// <summary>
        /// Gets the PreviouspanoramaDogbreedsLetterE_Detail0 command.
        /// </summary>
        public ICommand PreviouspanoramaDogbreedsLetterE_Detail0
        {
            get { return _previouspanoramaDogbreedsLetterE_Detail0 = _previouspanoramaDogbreedsLetterE_Detail0 ?? new ViewModelsBase.DelegateCommand(PreviouspanoramaDogbreedsLetterE_Detail0Delegate); }
        }

        private void RefreshHasPrevNext()
        {
            HasPreviouspanoramaDogbreedsLetterE_Detail0 = _dogbreedsLetterE_DogbreedsLetterE.HasPrevious(CurrentDogbreedsLetterESchema);
			HasNextpanoramaDogbreedsLetterE_Detail0 = _dogbreedsLetterE_DogbreedsLetterE.HasNext(CurrentDogbreedsLetterESchema);
		}
		public object NavigationContext
        {
            set
            {              
                if (!(value is Entities.DogbreedsLetterESchema)) { return; }
                
                CurrentDogbreedsLetterESchema = value as Entities.DogbreedsLetterESchema;
                RefreshHasPrevNext();
            }
        }
        /// <summary>
        /// Initializes a <see cref="Services.TileInfo" /> object for the DogbreedsLetterE_DetailStaticControl control.
        /// </summary>
		/// <returns>A <see cref="Services.TileInfo" /> object.</returns>
        public Services.TileInfo CreateTileInfoDogbreedsLetterE_DetailStaticControl()
        {
            var tileInfo = new Services.TileInfo
            {
                CurrentId = CurrentDogbreedsLetterESchema.Id.ToString(),
                Title = CurrentDogbreedsLetterESchema.Subtitle,
                BackTitle = CurrentDogbreedsLetterESchema.Subtitle,
                BackContent = CurrentDogbreedsLetterESchema.Description,
                Count = 0,
                BackgroundImagePath = CurrentDogbreedsLetterESchema.Image,
                BackBackgroundImagePath = CurrentDogbreedsLetterESchema.Image,
                LogoPath = "Item-46655a22-e9de-4ba1-8c70-bb036184cb54.png"
            };
            return tileInfo;
        }
    }
}