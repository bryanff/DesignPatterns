using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Proxy.BlockerContent
{
    public class PinterestCacheProxy : IImageProvider
    {
        private readonly IImageProvider _provider;
        private readonly AuthService _authService;
        private readonly IBlocker _blocker;
        private Dictionary<string, Image> _explicitContent = new Dictionary<string, Image>();
        private Dictionary<string, Image> _allPublic = new Dictionary<string, Image>();
        public PinterestCacheProxy(IImageProvider provider, AuthService authService, IBlocker blocker)
        {
            this._provider = provider;
            this._authService = authService;
            this._blocker = blocker;
        }
        public Dictionary<string, Image> getExplicitImages()
        {
            if (!_blocker.IsSituable(_authService.getAuthenticated().Age))
                throw new UnauthorizedAccessException();
            if (_explicitContent.Count == 0)
                _explicitContent = _provider.getExplicitImages();
            return _explicitContent;
        }
        public Dictionary<string, Image> getPublicImages()
        {
            if (_allPublic.Count == 0)
                _allPublic = _provider.getPublicImages();
            return _allPublic;
        }
    }
}
