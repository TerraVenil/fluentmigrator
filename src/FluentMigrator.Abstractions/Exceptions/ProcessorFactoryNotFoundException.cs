#region License

// Copyright (c) 2007-2018, Sean Chambers <schambers80@gmail.com>
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

#endregion

using System;
using System.Runtime.Serialization;

namespace FluentMigrator.Exceptions
{
    /// <summary>
    /// Exception that gets thrown when a processor factory couldn't be found
    /// </summary>
    [Serializable]
    public class ProcessorFactoryNotFoundException : FluentMigratorException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessorFactoryNotFoundException"/> class.
        /// </summary>
        public ProcessorFactoryNotFoundException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessorFactoryNotFoundException"/> class.
        /// </summary>
        /// <param name="message">The exception message</param>
        public ProcessorFactoryNotFoundException(string message) : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessorFactoryNotFoundException"/> class.
        /// </summary>
        /// <param name="message">The exception message</param>
        /// <param name="innerException">The inner exception</param>
        public ProcessorFactoryNotFoundException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessorFactoryNotFoundException"/> class.
        /// </summary>
        /// <param name="info">The serialization information</param>
        /// <param name="context">The streaming context</param>
        public ProcessorFactoryNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
