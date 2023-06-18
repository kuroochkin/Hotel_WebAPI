using Hotel.App.Room.Commands.CreateBooking;
using Hotel.App.Room.Vm;
using Hotel.Contracts.Room.Get;
using Hotel.Contracts.Room.Requests;
using Mapster;
using Microsoft.EntityFrameworkCore.Design;

namespace Hotel.API.Common.Mapping;

public class RoomMappingConfig : IRegister
{
	public void Register(TypeAdapterConfig config)
	{
		config.NewConfig<RoomsVm, GetRoomsResponse>()
			.Map(dest => dest.Rooms, src => src.Rooms);

		config.NewConfig<RoomDetailsVm, GetRoomDetailsResponse>()
			.Map(dest => dest.Id, src => src.Id)
			.Map(dest => dest.Category, src => src.Category)
			.Map(dest => dest.Condition, src => src.Condition)
			.Map(dest => dest.Thumbnail, src => src.Thumbnail);

		config.NewConfig<CategoryRoomVm, CategoryRoomResponse>()
			.Map(dest => dest.Id, src => src.Id)
			.Map(dest => dest.Category, src => src.Category)
			.Map(dest => dest.Description, src => src.Description)
			.Map(dest => dest.QuantityPersons, src => src.QuantityPersons)
			.Map(dest => dest.QuantityRooms, src => src.QuantityRooms)
			.Map(dest => dest.QuantityRooms, src => src.QuantityRooms)
			.Map(dest => dest.Price, src => src.Price);

		config.NewConfig<RoomConditionVm, RoomConditionResponse>()
			.Map(dest => dest.Id, src => src.Id)
			.Map(dest => dest.Employee, src => src.Employee)
			.Map(dest => dest.Booking, src => src.Booking)
			.Map(dest => dest.CheckIn, src => src.CheckIn)
			.Map(dest => dest.Departure, src => src.Departure)
			.Map(dest => dest.TotalPrice, src => src.TotalPrice);

		config.NewConfig<EmployeeVm, EmployeeResponse>()
			.Map(dest => dest.Id, src => src.Id)
			.Map(dest => dest.LastName, src => src.FirstName)
			.Map(dest => dest.Patronymic, src => src.Patronymic)
			.Map(dest => dest.Birthday, src => src.Birthday)
			.Map(dest => dest.Education, src => src.Education)
			.Map(dest => dest.JobTitle, src => src.JobTitle)
			.Map(dest => dest.Salary, src => src.Salary);

		config.NewConfig<BookingVm, BookingResponse>()
			.Map(dest => dest.Id, src => src.Id)
			.Map(dest => dest.Status, src => src.Status);

		config.NewConfig<JobtitleVm, JobtitleResponse>()
			.Map(dest => dest.Id, src => src.Id)
			.Map(dest => dest.JobTitle, src => src.JobTitle);

		config.NewConfig<CreateBookingRequest, CreateBookingCommand>()
			.Map(dest => dest.RoomId, src => src.roomId)
			.Map(dest => dest.TotalPrice, src => src.totalPrice);



	}
}
