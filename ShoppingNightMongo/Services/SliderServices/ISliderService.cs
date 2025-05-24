using ShoppingNightMongo.Dtos.SliderDtos;

namespace ShoppingNightMongo.Services.SliderServices
{
    public interface ISliderService
    {
        Task<List<ResultSliderDto>> GetAllSliderAsync();
        Task<GetSliderByIdDto> GetSliderByIdAsync(string id);
        Task CreateSliderAsync(CreateSliderDto createSliderDto);
        Task UpdateSliderAsync(UpdateSliderDto updateSliderDto);
        Task DeleteSliderAsync(string id);
    }
}
