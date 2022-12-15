using AutoMapper;
using Moq;
using Shouldly;
using Unik_OnBoarding.Application.Features.Kunde.Queries.GetKundeList;
using Unik_OnBoarding.Application.Implementation.Kunde.dto;
using Unik_OnBoarding.Application.Interfaceses;
using Unik_OnBoarding.Application.Mappers;
using Unik_OnBoarding.Domain.Model;

namespace Unik_OnBording.Tests
{
    public class GetCommandsTests
    {
        private readonly Mock<IKundeRepository> _kundeRepo;
        private readonly IMapper _mapper;
        public GetCommandsTests ( )
        {
            _kundeRepo = new Mock<IKundeRepository>( );

            var mapperConfig = new MapperConfiguration(c =>
            {
                c.AddProfile<AutoMapping>( );
            });

            _mapper = mapperConfig.CreateMapper( );
        }
        [Fact]
        public async Task Test_KundeGetCommandHandler ( )
        {
            var KundeList = new List<KundeEntity>
            {
                new KundeEntity
                {
                    Kid = Guid.Parse("{60277576-b364-4c1b-ba02-82c508667183}"),
                    Fornavn = "Test Vacation",
                    Email="",
                    Telefon="92939456",
                    Adresse="some adress"
                }
            };
            var handler = new GetKundeListQueryHandler(_kundeRepo.Object, _mapper);
            var result = await handler.Handle(new GetKundeListQuery( ), CancellationToken.None);
            _kundeRepo.Setup(r => r.GetAllKundeAsync(false)).ReturnsAsync(KundeList);

            result.ShouldBeOfType<List<KundeDto>>( );
        }

        [Fact]
        public async Task Test_GetDetailsCommandHandler ( )
        {
            var kDtop = new KundeDto( )
            {
                Kid = Guid.Parse("{60277576-b364-4c1b-ba02-82c508667183}"),
                Fornavn = "Test Vacation",
                Email = "",
                Telefon = "92939456",
                Adresse = "some adress"
            };
            var Kunde =
                new KundeEntity
                {
                    Kid = Guid.Parse("{60277576-b364-4c1b-ba02-82c508667183}"),
                    Fornavn = "Test Vacation",
                    Email = "",
                    Telefon = "92939456",
                    Adresse = "some adress"
                };
            var handler = new GetKundeListQueryHandler(_kundeRepo.Object, _mapper);
            var result = await handler.Handle(new GetKundeListQuery( ), CancellationToken.None);
            _kundeRepo.Setup(r => r.GetByIdAsync(kDtop.Kid));

            result.ShouldBeOfType<List<KundeDto>>( );
        }
    }
}