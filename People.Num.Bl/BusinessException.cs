/*
    Ing. Xavier Acosta Polo
    24 de mayo de 2018
*/

namespace People.Num.Bl
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Clase de manejo de excepciones.
    /// </summary>
    [Serializable]
    public class BusinessException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessException"/> class.
        /// </summary>
        public BusinessException()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessException"/> class.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        public BusinessException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessException"/> class.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="innerException">The exception that is the cause of the current exception, or 
        /// a null reference (Nothing in Visual Basic) if no inner exception is specified.</param>
        public BusinessException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessException"/> class.
        /// </summary>
        /// <param name="info">Serialization info.</param>
        /// <param name="context">Streaming Context.</param>
        protected BusinessException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
