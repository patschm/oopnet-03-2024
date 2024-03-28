using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraStructure
{
    internal class Point
    {
        private readonly ILogger<Point> _logger;

        public Point(ILogger<Point> logger)
        {
            _logger = logger;
        }

        public void DoPointyStuff()
        {
            _logger.LogCritical("Critical (5)");
            _logger.LogError("Error (4)");
            _logger.LogWarning("Warning (3)");
            _logger.LogInformation("Information (2)");
            _logger.LogDebug("Debug (1)");
            _logger.LogTrace("Trace (0)");
            // None (6)
        }
    }
}
