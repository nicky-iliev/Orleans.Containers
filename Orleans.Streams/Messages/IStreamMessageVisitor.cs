﻿using System.Threading.Tasks;

namespace Orleans.Streams.Messages
{
    public interface IStreamMessageVisitor
    {
        Task Visit(IStreamMessage streamMessage);
    }
}