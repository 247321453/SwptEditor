﻿// Copyright 2021 Crystal Ferrai
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//    http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using SwptSaveEditor.Utils;

namespace SwptSaveEditor.Document
{
    /// <summary>
    /// Service for managing documents
    /// </summary>
    internal class DocumentService : ObservableObject
    {
        /// <summary>
        /// Gets or sets the currently active document
        /// </summary>
        public IDocument ActiveDocument
        {
            get => _activeDocu8ment;
            set => Set(ref _activeDocu8ment, value);
        }
        private IDocument _activeDocu8ment;
    }
}
