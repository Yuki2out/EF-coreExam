using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Instagram.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixPostImageNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Followers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FollowerId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FollowingId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Followers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SenderId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReciverId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Read = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Followers",
                columns: new[] { "Id", "CreatedAt", "FollowerId", "FollowingId" },
                values: new object[,]
                {
                    { "follow-01-a81f", new DateTime(2025, 1, 5, 10, 0, 0, 0, DateTimeKind.Utc), "a6a7d7a9-43e5-4ad1-9c89-41287b4d3902", "1c7a44e8-6c82-4a51-8e77-15bdfd5b8a01" },
                    { "follow-02-b19f", new DateTime(2025, 1, 5, 11, 0, 0, 0, DateTimeKind.Utc), "f52b5f4d-8c4e-4b3a-91fd-3c79cdb1c903", "1c7a44e8-6c82-4a51-8e77-15bdfd5b8a01" },
                    { "follow-03-c7fa", new DateTime(2025, 1, 6, 9, 0, 0, 0, DateTimeKind.Utc), "c91e9189-281f-48c3-b8ad-1b20f4f10104", "a6a7d7a9-43e5-4ad1-9c89-41287b4d3902" },
                    { "follow-04-d812", new DateTime(2025, 1, 6, 10, 0, 0, 0, DateTimeKind.Utc), "da3a7cb3-5d90-45d2-83d9-9f8a2d92a105", "f52b5f4d-8c4e-4b3a-91fd-3c79cdb1c903" },
                    { "follow-05-e811", new DateTime(2025, 1, 7, 11, 0, 0, 0, DateTimeKind.Utc), "b9f4c2d1-4d94-4ff6-87aa-0ccf933bf106", "e38db6c0-7b92-4f0f-b76a-d7b7f1aab107" },
                    { "follow-06-f211", new DateTime(2025, 1, 8, 12, 0, 0, 0, DateTimeKind.Utc), "17a7f919-62b3-4b1b-94bb-8cf80b8aa108", "c6fdb72c-65b1-42df-bd03-4a3ff37f6109" },
                    { "follow-07-911a", new DateTime(2025, 1, 8, 14, 0, 0, 0, DateTimeKind.Utc), "88dfb5b0-12c2-42d6-bb0d-9eaa9e9a3110", "bf8ad623-ff4a-44b3-b2b2-109cbe8a2111" },
                    { "follow-08-71ab", new DateTime(2025, 1, 9, 9, 0, 0, 0, DateTimeKind.Utc), "2df3b7c4-29c2-41b2-b2cb-51c8f20d8112", "4b46a84d-21a3-44db-9d2f-68c2f51f3113" },
                    { "follow-09-2f81", new DateTime(2025, 1, 10, 10, 0, 0, 0, DateTimeKind.Utc), "aa9aef99-4d6f-4b7a-b3a7-0b2b8d731116", "82b1e839-f782-4c16-a1c2-2f8f1a2a5115" },
                    { "follow-10-91af", new DateTime(2025, 1, 11, 11, 0, 0, 0, DateTimeKind.Utc), "bbcfb1c7-d4a6-46fa-a9cc-5c9df8d07117", "d14dc8ad-3b9f-4f1a-b50a-82d0c3e71118" },
                    { "follow-11-acde", new DateTime(2025, 1, 12, 9, 0, 0, 0, DateTimeKind.Utc), "1c7a44e8-6c82-4a51-8e77-15bdfd5b8a01", "a6a7d7a9-43e5-4ad1-9c89-41287b4d3902" },
                    { "follow-12-acde", new DateTime(2025, 1, 12, 9, 30, 0, 0, DateTimeKind.Utc), "1c7a44e8-6c82-4a51-8e77-15bdfd5b8a01", "f52b5f4d-8c4e-4b3a-91fd-3c79cdb1c903" },
                    { "follow-13-acde", new DateTime(2025, 1, 13, 10, 0, 0, 0, DateTimeKind.Utc), "a6a7d7a9-43e5-4ad1-9c89-41287b4d3902", "da3a7cb3-5d90-45d2-83d9-9f8a2d92a105" },
                    { "follow-14-acde", new DateTime(2025, 1, 13, 11, 0, 0, 0, DateTimeKind.Utc), "f52b5f4d-8c4e-4b3a-91fd-3c79cdb1c903", "b9f4c2d1-4d94-4ff6-87aa-0ccf933bf106" },
                    { "follow-15-acde", new DateTime(2025, 1, 14, 9, 0, 0, 0, DateTimeKind.Utc), "c6fdb72c-65b1-42df-bd03-4a3ff37f6109", "88dfb5b0-12c2-42d6-bb0d-9eaa9e9a3110" },
                    { "follow-16-acde", new DateTime(2025, 1, 14, 10, 0, 0, 0, DateTimeKind.Utc), "82b1e839-f782-4c16-a1c2-2f8f1a2a5115", "aa9aef99-4d6f-4b7a-b3a7-0b2b8d731116" },
                    { "follow-17-acde", new DateTime(2025, 1, 15, 11, 0, 0, 0, DateTimeKind.Utc), "d14dc8ad-3b9f-4f1a-b50a-82d0c3e71118", "1c7a44e8-6c82-4a51-8e77-15bdfd5b8a01" },
                    { "follow-18-acde", new DateTime(2025, 1, 16, 9, 0, 0, 0, DateTimeKind.Utc), "bbcfb1c7-d4a6-46fa-a9cc-5c9df8d07117", "a6a7d7a9-43e5-4ad1-9c89-41287b4d3902" },
                    { "follow-19-acde", new DateTime(2025, 1, 17, 10, 0, 0, 0, DateTimeKind.Utc), "17a7f919-62b3-4b1b-94bb-8cf80b8aa108", "1c7a44e8-6c82-4a51-8e77-15bdfd5b8a01" },
                    { "follow-20-acde", new DateTime(2025, 1, 18, 9, 0, 0, 0, DateTimeKind.Utc), "2df3b7c4-29c2-41b2-b2cb-51c8f20d8112", "82b1e839-f782-4c16-a1c2-2f8f1a2a5115" }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Content", "CreatedAt", "Read", "ReciverId", "SenderId" },
                values: new object[,]
                {
                    { "msg-001-4a8f1b01", "Hey, did you finish the API changes?", new DateTime(2026, 1, 1, 9, 0, 0, 0, DateTimeKind.Utc), true, "", "1c7a44e8-6c82-4a51-8e77-15bdfd5b8a01" },
                    { "msg-002-92bc1102", "Almost, just fixing validation.", new DateTime(2026, 1, 1, 9, 2, 0, 0, DateTimeKind.Utc), true, "", "a6a7d7a9-43e5-4ad1-9c89-41287b4d3902" },
                    { "msg-003-ff21ac03", "Nice, ping me when ready.", new DateTime(2026, 1, 1, 9, 3, 0, 0, DateTimeKind.Utc), true, "", "1c7a44e8-6c82-4a51-8e77-15bdfd5b8a01" },
                    { "msg-004-bac91204", "Can you review my UI mockups?", new DateTime(2026, 1, 1, 11, 10, 0, 0, DateTimeKind.Utc), true, "", "f52b5f4d-8c4e-4b3a-91fd-3c79cdb1c903" },
                    { "msg-005-acde3305", "Sure, send them.", new DateTime(2026, 1, 1, 11, 12, 0, 0, DateTimeKind.Utc), true, "", "da3a7cb3-5d90-45d2-83d9-9f8a2d92a105" },
                    { "msg-006-219fa006", "Using Docker Compose?", new DateTime(2026, 1, 2, 8, 30, 0, 0, DateTimeKind.Utc), true, "", "b9f4c2d1-4d94-4ff6-87aa-0ccf933bf106" },
                    { "msg-007-77cbe007", "Yes, makes networking easier.", new DateTime(2026, 1, 2, 8, 33, 0, 0, DateTimeKind.Utc), true, "", "e38db6c0-7b92-4f0f-b76a-d7b7f1aab107" },
                    { "msg-008-19aa2008", "Loved your last blog post.", new DateTime(2026, 1, 2, 12, 0, 0, 0, DateTimeKind.Utc), true, "", "17a7f919-62b3-4b1b-94bb-8cf80b8aa108" },
                    { "msg-009-b211c009", "Thanks a lot!", new DateTime(2026, 1, 2, 12, 2, 0, 0, DateTimeKind.Utc), true, "", "c6fdb72c-65b1-42df-bd03-4a3ff37f6109" },
                    { "msg-010-a88cc010", "How do you track analytics?", new DateTime(2026, 1, 3, 9, 30, 0, 0, DateTimeKind.Utc), false, "", "88dfb5b0-12c2-42d6-bb0d-9eaa9e9a3110" },
                    { "msg-011-acde1011", "Mostly Firebase and custom events.", new DateTime(2026, 1, 3, 9, 32, 0, 0, DateTimeKind.Utc), false, "", "bf8ad623-ff4a-44b3-b2b2-109cbe8a2111" },
                    { "msg-012-acde1012", "QA found a bug in checkout.", new DateTime(2026, 1, 3, 11, 10, 0, 0, DateTimeKind.Utc), true, "", "2df3b7c4-29c2-41b2-b2cb-51c8f20d8112" },
                    { "msg-013-acde1013", "Thanks, I’ll fix it today.", new DateTime(2026, 1, 3, 11, 12, 0, 0, DateTimeKind.Utc), true, "", "4b46a84d-21a3-44db-9d2f-68c2f51f3113" },
                    { "msg-014-acde1014", "Any cloud provider recommendations?", new DateTime(2026, 1, 4, 8, 0, 0, 0, DateTimeKind.Utc), true, "", "5d7e09fa-b71a-44c5-9e1f-9b4e4b09f114" },
                    { "msg-015-acde1015", "Azure is solid for .NET.", new DateTime(2026, 1, 4, 8, 2, 0, 0, DateTimeKind.Utc), true, "", "aa9aef99-4d6f-4b7a-b3a7-0b2b8d731116" },
                    { "msg-016-acde1016", "Meeting moved to tomorrow.", new DateTime(2026, 1, 4, 15, 20, 0, 0, DateTimeKind.Utc), true, "", "82b1e839-f782-4c16-a1c2-2f8f1a2a5115" },
                    { "msg-017-acde1017", "Got it, thanks.", new DateTime(2026, 1, 4, 15, 22, 0, 0, DateTimeKind.Utc), true, "", "bbcfb1c7-d4a6-46fa-a9cc-5c9df8d07117" },
                    { "msg-018-acde1018", "Want to discuss the startup idea?", new DateTime(2026, 1, 5, 10, 0, 0, 0, DateTimeKind.Utc), false, "", "d14dc8ad-3b9f-4f1a-b50a-82d0c3e71118" },
                    { "msg-019-acde1019", "Yes, let’s do it later today.", new DateTime(2026, 1, 5, 10, 5, 0, 0, DateTimeKind.Utc), false, "", "1c7a44e8-6c82-4a51-8e77-15bdfd5b8a01" },
                    { "msg-020-acde1020", "Can you help me with React hooks?", new DateTime(2026, 1, 6, 9, 0, 0, 0, DateTimeKind.Utc), true, "", "17a7f919-62b3-4b1b-94bb-8cf80b8aa108" },
                    { "msg-021-acde1021", "Sure, what part?", new DateTime(2026, 1, 6, 9, 1, 0, 0, DateTimeKind.Utc), true, "", "a6a7d7a9-43e5-4ad1-9c89-41287b4d3902" },
                    { "msg-022-acde1022", "useEffect dependencies confuse me.", new DateTime(2026, 1, 6, 9, 3, 0, 0, DateTimeKind.Utc), true, "", "17a7f919-62b3-4b1b-94bb-8cf80b8aa108" },
                    { "msg-023-acde1023", "They control when the effect runs.", new DateTime(2026, 1, 6, 9, 5, 0, 0, DateTimeKind.Utc), true, "", "a6a7d7a9-43e5-4ad1-9c89-41287b4d3902" },
                    { "msg-024-acde1024", "Ahh that helps a lot.", new DateTime(2026, 1, 6, 9, 6, 0, 0, DateTimeKind.Utc), true, "", "17a7f919-62b3-4b1b-94bb-8cf80b8aa108" },
                    { "msg-025-acde1025", "Security scan passed.", new DateTime(2026, 1, 7, 10, 0, 0, 0, DateTimeKind.Utc), true, "", "c91e9189-281f-48c3-b8ad-1b20f4f10104" },
                    { "msg-026-acde1026", "Great news!", new DateTime(2026, 1, 7, 10, 1, 0, 0, DateTimeKind.Utc), true, "", "b9f4c2d1-4d94-4ff6-87aa-0ccf933bf106" },
                    { "msg-027-acde1027", "Want to test the beta build?", new DateTime(2026, 1, 8, 14, 0, 0, 0, DateTimeKind.Utc), true, "", "e38db6c0-7b92-4f0f-b76a-d7b7f1aab107" },
                    { "msg-028-acde1028", "Sure, send the link.", new DateTime(2026, 1, 8, 14, 1, 0, 0, DateTimeKind.Utc), true, "", "bf8ad623-ff4a-44b3-b2b2-109cbe8a2111" },
                    { "msg-029-acde1029", "Presentation slides ready.", new DateTime(2026, 1, 9, 9, 0, 0, 0, DateTimeKind.Utc), true, "", "88dfb5b0-12c2-42d6-bb0d-9eaa9e9a3110" },
                    { "msg-030-acde1030", "Perfect, thanks.", new DateTime(2026, 1, 9, 9, 2, 0, 0, DateTimeKind.Utc), true, "", "82b1e839-f782-4c16-a1c2-2f8f1a2a5115" },
                    { "msg-031-acde1031", "Java service deployed.", new DateTime(2026, 1, 10, 11, 0, 0, 0, DateTimeKind.Utc), true, "", "4b46a84d-21a3-44db-9d2f-68c2f51f3113" },
                    { "msg-032-acde1032", "Monitoring looks good.", new DateTime(2026, 1, 10, 11, 5, 0, 0, DateTimeKind.Utc), true, "", "aa9aef99-4d6f-4b7a-b3a7-0b2b8d731116" },
                    { "msg-033-acde1033", "Smart contract deployed.", new DateTime(2026, 1, 11, 13, 0, 0, 0, DateTimeKind.Utc), true, "", "5d7e09fa-b71a-44c5-9e1f-9b4e4b09f114" },
                    { "msg-034-acde1034", "Awesome work.", new DateTime(2026, 1, 11, 13, 2, 0, 0, DateTimeKind.Utc), true, "", "d14dc8ad-3b9f-4f1a-b50a-82d0c3e71118" },
                    { "msg-035-acde1035", "Interviews scheduled.", new DateTime(2026, 1, 12, 10, 0, 0, 0, DateTimeKind.Utc), true, "", "bbcfb1c7-d4a6-46fa-a9cc-5c9df8d07117" },
                    { "msg-036-acde1036", "Thanks for the update.", new DateTime(2026, 1, 12, 10, 1, 0, 0, DateTimeKind.Utc), true, "", "82b1e839-f782-4c16-a1c2-2f8f1a2a5115" },
                    { "msg-037-acde1037", "Want to co-author an article?", new DateTime(2026, 1, 13, 15, 0, 0, 0, DateTimeKind.Utc), false, "", "c6fdb72c-65b1-42df-bd03-4a3ff37f6109" },
                    { "msg-038-acde1038", "Yes, sounds great.", new DateTime(2026, 1, 13, 15, 5, 0, 0, DateTimeKind.Utc), false, "", "1c7a44e8-6c82-4a51-8e77-15bdfd5b8a01" },
                    { "msg-039-acde1039", "Your design tips helped!", new DateTime(2026, 1, 14, 9, 0, 0, 0, DateTimeKind.Utc), true, "", "17a7f919-62b3-4b1b-94bb-8cf80b8aa108" },
                    { "msg-040-acde1040", "Happy to hear that 😊", new DateTime(2026, 1, 14, 9, 2, 0, 0, DateTimeKind.Utc), true, "", "f52b5f4d-8c4e-4b3a-91fd-3c79cdb1c903" },
                    { "msg-041-acde1041", "Artwork campaign looks great.", new DateTime(2026, 1, 15, 11, 0, 0, 0, DateTimeKind.Utc), true, "", "88dfb5b0-12c2-42d6-bb0d-9eaa9e9a3110" },
                    { "msg-042-acde1042", "Thanks! Glad you liked it.", new DateTime(2026, 1, 15, 11, 2, 0, 0, DateTimeKind.Utc), true, "", "da3a7cb3-5d90-45d2-83d9-9f8a2d92a105" },
                    { "msg-043-acde1043", "Mobile build ready for testing.", new DateTime(2026, 1, 16, 16, 0, 0, 0, DateTimeKind.Utc), true, "", "bf8ad623-ff4a-44b3-b2b2-109cbe8a2111" },
                    { "msg-044-acde1044", "I’ll test it tonight.", new DateTime(2026, 1, 16, 16, 5, 0, 0, DateTimeKind.Utc), true, "", "1c7a44e8-6c82-4a51-8e77-15bdfd5b8a01" },
                    { "msg-045-acde1045", "Logs look clean.", new DateTime(2026, 1, 17, 10, 0, 0, 0, DateTimeKind.Utc), true, "", "aa9aef99-4d6f-4b7a-b3a7-0b2b8d731116" },
                    { "msg-046-acde1046", "Great 👍", new DateTime(2026, 1, 17, 10, 1, 0, 0, DateTimeKind.Utc), true, "", "b9f4c2d1-4d94-4ff6-87aa-0ccf933bf106" },
                    { "msg-047-acde1047", "Roadmap approved.", new DateTime(2026, 1, 18, 9, 0, 0, 0, DateTimeKind.Utc), true, "", "82b1e839-f782-4c16-a1c2-2f8f1a2a5115" },
                    { "msg-048-acde1048", "Perfect, let’s move forward.", new DateTime(2026, 1, 18, 9, 2, 0, 0, DateTimeKind.Utc), true, "", "d14dc8ad-3b9f-4f1a-b50a-82d0c3e71118" },
                    { "msg-049-acde1049", "Publishing tomorrow.", new DateTime(2026, 1, 19, 14, 0, 0, 0, DateTimeKind.Utc), false, "", "c6fdb72c-65b1-42df-bd03-4a3ff37f6109" },
                    { "msg-050-acde1050", "Great timing.", new DateTime(2026, 1, 19, 14, 1, 0, 0, DateTimeKind.Utc), false, "", "88dfb5b0-12c2-42d6-bb0d-9eaa9e9a3110" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "CreatedAt", "Image", "UserId" },
                values: new object[,]
                {
                    { "post-01-9f1b4d8a-21c0-4f5c-b102-a001", "Started rebuilding my backend architecture today.", new DateTime(2026, 1, 1, 8, 0, 0, 0, DateTimeKind.Utc), null, "" },
                    { "post-02-7c2a5d11-2e90-4bcb-a901-a002", "React hooks finally make sense.", new DateTime(2026, 1, 1, 9, 15, 0, 0, DateTimeKind.Utc), null, "" },
                    { "post-03-b81a7a29-0b8c-4a3b-b621-a003", "Designing a fresh dark theme UI 🌙", new DateTime(2026, 1, 1, 10, 40, 0, 0, DateTimeKind.Utc), "/posts/3.jpg", "" },
                    { "post-04-21f7ac19-91c2-48bb-b812-a004", "Learning penetration testing basics.", new DateTime(2026, 1, 1, 12, 0, 0, 0, DateTimeKind.Utc), null, "" },
                    { "post-05-3d71a8b4-7731-4b42-93b2-a005", "New illustration finished today 🎨", new DateTime(2026, 1, 1, 13, 25, 0, 0, DateTimeKind.Utc), "/posts/5.jpg", "" },
                    { "post-06-41bc8c90-d241-4aa4-9921-a006", "Docker containers saved my sanity.", new DateTime(2026, 1, 1, 15, 0, 0, 0, DateTimeKind.Utc), null, "" },
                    { "post-07-19f7d901-8f62-4b98-8211-a007", "Experimenting with game physics today.", new DateTime(2026, 1, 2, 9, 30, 0, 0, DateTimeKind.Utc), "/posts/7.jpg", "" },
                    { "post-08-771a9d44-6f11-4d55-b341-a008", "Exams week again 😭", new DateTime(2026, 1, 2, 11, 0, 0, 0, DateTimeKind.Utc), null, "" },
                    { "post-09-5a6a7b28-3810-4d6a-9c81-a009", "Publishing my next tech article soon.", new DateTime(2026, 1, 2, 13, 45, 0, 0, DateTimeKind.Utc), "/posts/9.jpg", "" },
                    { "post-10-9912a83a-2489-4f7b-9a31-a010", "Analytics dashboards are addictive.", new DateTime(2026, 1, 2, 16, 0, 0, 0, DateTimeKind.Utc), null, "" },
                    { "post-11-84b7d312-fb20-41ad-9012-a011", "Mobile app memory usage finally optimized.", new DateTime(2026, 1, 3, 9, 0, 0, 0, DateTimeKind.Utc), null, "" },
                    { "post-12-27b7f981-21a0-4db6-81f1-a012", "QA automation saves weeks of work.", new DateTime(2026, 1, 3, 10, 10, 0, 0, DateTimeKind.Utc), null, "" },
                    { "post-13-fbc38d22-7b2a-4c51-a819-a013", "Java memory tuning is underrated.", new DateTime(2026, 1, 3, 11, 40, 0, 0, DateTimeKind.Utc), null, "" },
                    { "post-14-91d72d19-2ab0-4e18-9f10-a014", "Reading about smart contracts today.", new DateTime(2026, 1, 3, 13, 20, 0, 0, DateTimeKind.Utc), null, "" },
                    { "post-15-31aa20fa-1e0c-4a4f-902a-a015", "Sprint planning done ✔️", new DateTime(2026, 1, 3, 15, 0, 0, 0, DateTimeKind.Utc), null, "" },
                    { "post-16-ff2b91d0-7e42-46ad-a0f9-a016", "Cloud cost optimization is painful.", new DateTime(2026, 1, 4, 9, 0, 0, 0, DateTimeKind.Utc), null, "" },
                    { "post-17-62cbd91a-f61e-4ef7-93fa-a017", "Hiring developers is harder than coding.", new DateTime(2026, 1, 4, 10, 30, 0, 0, DateTimeKind.Utc), null, "" },
                    { "post-18-1187a1df-4f42-4b02-b1f2-a018", "Pitch deck is almost ready 🚀", new DateTime(2026, 1, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, "" },
                    { "post-19-bc72fa01-3b22-4a83-9b41-a019", "JWT refresh tokens implemented.", new DateTime(2026, 1, 5, 9, 10, 0, 0, DateTimeKind.Utc), null, "" },
                    { "post-20-8c29f21a-5b81-47f2-a90c-a020", "Finally mastered CSS grid.", new DateTime(2026, 1, 5, 10, 45, 0, 0, DateTimeKind.Utc), null, "" },
                    { "post-21-37c29fa1-6e41-4012-a2b2-a021", "Minimal UI beats flashy UI.", new DateTime(2026, 1, 5, 12, 20, 0, 0, DateTimeKind.Utc), null, "" },
                    { "post-22-d31a8a41-ef02-42f7-8c3a-a022", "Sketching ideas for next artwork.", new DateTime(2026, 1, 5, 14, 0, 0, 0, DateTimeKind.Utc), "/posts/22.jpg", "" },
                    { "post-23-51c9b122-19fa-48e3-8db1-a023", "CI/CD pipelines should be boring.", new DateTime(2026, 1, 5, 16, 10, 0, 0, DateTimeKind.Utc), null, "" },
                    { "post-24-1a8f7e21-d22b-4c4e-a190-a024", "Procedural terrain generation test.", new DateTime(2026, 1, 6, 9, 0, 0, 0, DateTimeKind.Utc), "/posts/24.jpg", "" },
                    { "post-25-91c2df11-cc81-41fa-94b2-a025", "Coffee count today: 5 ☕", new DateTime(2026, 1, 6, 11, 0, 0, 0, DateTimeKind.Utc), null, "" },
                    { "post-26-62adf91b-421a-421f-b912-a026", "Tech blogging consistency is hard.", new DateTime(2026, 1, 6, 13, 0, 0, 0, DateTimeKind.Utc), null, "" },
                    { "post-27-9a81df21-1910-4d41-a401-a027", "Conversion metrics improved by 12%.", new DateTime(2026, 1, 6, 15, 0, 0, 0, DateTimeKind.Utc), null, "" },
                    { "post-28-2bc81df9-81fa-4f10-bd91-a028", "Flutter vs React Native debate continues.", new DateTime(2026, 1, 6, 17, 0, 0, 0, DateTimeKind.Utc), null, "" },
                    { "post-29-44bd9a01-2f10-4b72-b910-a029", "Regression tests passed ✅", new DateTime(2026, 1, 6, 18, 30, 0, 0, DateTimeKind.Utc), null, "" },
                    { "post-30-2f8a91c2-18b4-4db9-b120-a030", "Refactoring legacy code feels great.", new DateTime(2026, 1, 7, 9, 0, 0, 0, DateTimeKind.Utc), null, "" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Followers");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "Posts");
        }
    }
}
