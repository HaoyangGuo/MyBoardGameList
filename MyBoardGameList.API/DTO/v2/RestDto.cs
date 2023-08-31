namespace MyBoardGameList.API.DTO.v2
{
    public class RestDto<T>
    {
        public List<v1.LinkDto> Links { get; set; } = new List<v1.LinkDto>();

        public T Items { get; set; } = default!;
    }
}

