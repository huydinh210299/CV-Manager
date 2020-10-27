export const DEFAULT = {
    Name: 'Mẫu CV tiêu chuẩn',
    Label: `<img src="/content/image/mau-cv-default.jpg" width="100%" alt="" class="block-label-img"><div class="block-label-title">Mẫu CV tiêu chuẩn</div>`,
    Content :
    `
    <div class="cvo-page container-fluid" style="padding: 15mm;">
        <div class="cvo-profile row cvo-block" cvo-block-name="cvo-profile" style="padding: 3mm 4mm 7mm 4mm;">
            <div class="col-md-3 p-3">
                <img src="https://cdn.pixabay.com/photo/2016/08/08/09/17/avatar-1577909_1280.png"
                class="cvo-profile-avata" width="120" height="150"
                />
            </div>
            <div class="col-md-9 d-flex flex-column">
                <div class="cvo-profile-fullname" 
                style="
                font-size: 24pt;
                font-weight: 700;
                color: #0e2452;">Nguyễn Văn A</div>
                <div class="cvo-profile-title">Vị trí bạn muốn ứng tuyển</div>
                <div class="row">
                    <div class="col-md-3">Ngày sinh:</div>
                    <div class="col-md-9 cvo-profile-dob">21/21/1999</div>
                </div>
                <div class="row">
                    <div class="col-md-3">Giới tính:</div>
                    <div class="col-md-9 cvo-profile-gender">Nam</div>
                </div>
                <div class="row">
                    <div class="col-md-3">Điện thoại:</div>
                    <div class="col-md-9 cvo-profile-phone">012345678</div>
                </div>
                <div class="row">
                    <div class="col-md-3">Email:</div>
                    <div class="col-md-9 cvo-profile-email">abc@gmail.com</div>
                </div>
                <div class="row">
                    <div class="col-md-3">Địa chỉ:</div>
                    <div class="col-md-9 cvo-profile-website">facebook.com/213213</div>
                </div>
            </div>
        </div>
        <div class="cvo-objective cvo-block" cvo-block-name="cvo-objective" style="padding: 3mm 4mm 7mm 4mm;">
            <div class="cvo-objective-blocktitle" style="font-size: 12pt; font-weight: 700; border-bottom: thin solid #000; margin-bottom: 10px;">
                MỤC TIÊU NGHỀ NGHIỆP
            </div>
            <div class="cvo-objective-objective">
                Áp dụng những kinh nghiệm về kỹ năng bán hàng và sự hiểu biết về thị 
                trường để trở thành một nhân viên bán hàng chuyên nghiệp, 
                mang đến nhiều giá trị cho khách hàng. Từ đó giúp Công ty tăng số lượng khách hàng và mở rộng tập khách hàng.
            </div>
        </div>
        <div class="cvo-education cvo-block" cvo-block-name="cvo-education" style="padding: 3mm 4mm 7mm 4mm;">
            <div class="cvo-education-blocktitle" style="font-size: 12pt; font-weight: 700; border-bottom: thin solid #000; margin-bottom: 10px;">HỌC VẤN</div>
            <div class="cvo-education-table row">
                <div class="col-md-3 cvo-education-time ">08/2017 - Hiện tại</div>
                <div class="col-md-9">
                    <div class="row">
                        <div class="col-md-12 cvo-education-school">Đại học MYCV</div>
                        <div class="col-md-12 cvo-education-title">Chuyên ngành quản trị doanh nghiệp</div>
                        <div class="col-md-12 cvo-education-details">Tốt nghiệp loại Giỏi, điểm trung bình 8.0</div>
                    </div>
                </div>
            </div>
        </div>

        <div class="cvo-experience cvo-block" cvo-block-name="cvo-experience" style="padding: 3mm 4mm 7mm 4mm;">
            <div class="cvo-experience-blocktitle" style="font-size: 12pt; font-weight: 700; border-bottom: thin solid #000; margin-bottom: 10px;">KINH NGHIỆM LÀM VIỆC</div>
            <div class="cvo-experience-table row">
                <div class="col-md-3 cvo-experience-time ">08/2017 - Hiện tại</div>
                <div class="col-md-9">
                    <div class="row">
                        <div class="col-md-12 cvo-experience-company">Công ty MYCV</div>
                        <div class="col-md-12 cvo-experience-position">Nhân viên bán hàng</div>
                        <div class="col-md-12 cvo-experience-details">- Hỗ trợ viết bài quảng cáo sản phẩm qua kênh facebook, các forum,...
                            - Giới thiệu, tư vấn sản phẩm, giải đáp các vấn đề thắc mắc của khách hàng qua điện thoại và email.</div>
                    </div>
                </div>
            </div>
            <div class="cvo-experience-table row">
                <div class="col-md-3 cvo-experience-time ">08/2017 - Hiện tại</div>
                <div class="col-md-9">
                    <div class="row">
                        <div class="col-md-12 cvo-experience-company">Công ty MYCV</div>
                        <div class="col-md-12 cvo-experience-position">Nhân viên bán hàng</div>
                        <div class="col-md-12 cvo-experience-details">- Hỗ trợ viết bài quảng cáo sản phẩm qua kênh facebook, các forum,...
                            - Giới thiệu, tư vấn sản phẩm, giải đáp các vấn đề thắc mắc của khách hàng qua điện thoại và email.</div>
                    </div>
                </div>
            </div>
        </div>

        <div class="cvo-activity cvo-block" cvo-block-name="cvo-activity" style="padding: 3mm 4mm 7mm 4mm;">
            <div class="cvo-activity-blocktitle" style="font-size: 12pt; font-weight: 700; border-bottom: thin solid #000; margin-bottom: 10px;">HOẠT ĐỘNG</div>
            <div class="cvo-activity-table row">
                <div class="col-md-3 cvo-activity-time ">08/2017 - Hiện tại</div>
                <div class="col-md-9">
                    <div class="row">
                        <div class="col-md-12 cvo-activity-organization">Nhóm tình nguyện MYCV</div>
                        <div class="col-md-12 cvo-activity-position">Tình nguyện viên</div>
                        <div class="col-md-12 cvo-activity-details">Tập hợp các món quà và phân phát tới người vô gia cư.
                            - Chia sẻ, động viên họ vượt qua giai đoạn khó khăn, giúp họ có những suy nghĩ lạc quan.</div>
                    </div>
                </div>
            </div>
        </div>

        <div class="cvo-award cvo-block" cvo-block-name="cvo-award" style="padding: 3mm 4mm 7mm 4mm;">
            <div class="cvo-award-blocktitle" style="font-size: 12pt; font-weight: 700; border-bottom: thin solid #000; margin-bottom: 10px;">GIẢI THƯỞNG</div>
            <div class="cvo-award-table row">
                <div class="col-md-3 cvo-award-time ">08/2017 - Hiện tại</div>
                <div class="col-md-9">
                    <div class="row">
                        <div class="col-md-12 cvo-award-title">Giải nhất cuộc thi MYCV</div>
                    </div>
                </div>
            </div>
        </div>

        <div class="cvo-certification cvo-block" cvo-block-name="cvo-certification" style="padding: 3mm 4mm 7mm 4mm;">
            <div class="cvo-certification-blocktitle" style="font-size: 12pt; font-weight: 700; border-bottom: thin solid #000; margin-bottom: 10px;">CHỨNG CHỈ</div>
            <div class="cvo-certification-table row">
                <div class="col-md-3 cvo-certification-time ">08/2017 - Hiện tại</div>
                <div class="col-md-9">
                    <div class="row">
                        <div class="col-md-12 cvo-certification-title">Nhân viên xuất sắc năm công ty MYCV</div>
                    </div>
                </div>
            </div>
        </div>

        <div class="cvo-additional-info cvo-block" cvo-block-name="cvo-additional-info" style="padding: 3mm 4mm 7mm 4mm;">
            <div class="cvo-additional-info-blocktitle" style="font-size: 12pt; font-weight: 700; border-bottom: thin solid #000; margin-bottom: 10px;">THÔNG TIN THÊM</div>
            <div class="cvo-additional-information-details">
                Điền các thông tin khác (nếu có)
            </div>
        </div>

        <div class="cvo-reference cvo-block" cvo-block-name="cvo-reference" style="padding: 3mm 4mm 7mm 4mm;">
            <div class="cvo-reference-blocktitle" style="font-size: 12pt; font-weight: 700; border-bottom: thin solid #000; margin-bottom: 10px;">NGƯỜI THAM CHIẾU</div>
            <div class="cvo-reference-content">
                Anh... - Trưởng phòng Marketing
                Công ty TOPCV
                Điện thoại:...
            </div>
        </div>
        <div class="cvo-skillgroup cvo-block" cvo-block-name="cvo-skillgroup" style="padding: 3mm 4mm 7mm 4mm;">
            <div class="cvo-skillgroup-blocktitle" style="font-size: 12pt; font-weight: 700; border-bottom: thin solid #000; margin-bottom: 10px;">CÁC KỸ NĂNG</div>
            <div class="cvo-skill-table row">
                <div class="col-md-3 cvo-skillgroup-area">Nhóm kỹ năng</div>
                <div class="col-md-9 cvo-skillgroup-skill-description">Mô tả từng kỹ năng</div>
            </div>
        </div>

        <div class="cvo-interests cvo-block" cvo-block-name="cvo-interests" style="padding: 3mm 4mm 7mm 4mm;">
            <div class="cvo-interests-blocktitle" style="font-size: 12pt; font-weight: 700; border-bottom: thin solid #000; margin-bottom: 10px;">SỞ THÍCH</div>
            <div class="cvo-interests-content">
                Nói ngắn gọn về sở thích cá nhân
            </div>
        </div>

        <div class="cvo-project cvo-block" cvo-block-name="cvo-project" style="padding: 3mm 4mm 7mm 4mm;">
            <div class="cvo-project-blocktitle" style="font-size: 12pt; font-weight: 700; border-bottom: thin solid #000; margin-bottom: 10px;">DỰ ÁN</div>
            <div class="cvo-project-project-name" style="font-size: 14pt">Tên dự án</div>
            <div class="cvo-project-time">(Bắt đầu - Kết thúc)</div>
            <div class="project_details">
                <table style="border: thin solid black; width: 100%; text-indent: 0.5rem;">
                <tr style="border-bottom: thin solid black;">
                    <td style="width: 30%;border-right: thin solid black;">Khách hàng</td>
                    <td><div>Khách hàng</div></td>
                </tr>
                <tr style="border-bottom: thin solid black;">
                    <td style="width: 30%;border-right: thin solid black;">Mô tả dự án</td>
                    <td><div>Mô tả dự án</div></td>
                </tr>
                <tr style="border-bottom: thin solid black;">
                    <td style="width: 30%;border-right: thin solid black;">Số lượng thành viên</td>
                    <td><div>Số lượng thành viên</div></td>
                </tr>
                <tr style="border-bottom: thin solid black;">
                    <td style="width: 30%;border-right: thin solid black;">Vị trí công việc</td>
                    <td><div>Vị trí công việc</div></td>
                </tr>
                <tr style="border-bottom: thin solid black;">
                    <td style="width: 30%;border-right: thin solid black;">Vai trò trong dự án</td>
                    <td><div>Vai trò trong dự án</div></td>
                </tr>
                <tr style="border-bottom: thin solid black;">
                    <td style="width: 30%;border-right: thin solid black;">Công nghệ sử dụng</td>
                    <td><div>Công nghệ sử dụng</div></td>
                </tr>
            </table>
            </div>
        </div>
    </div>
    `,
    Category : 'DEFAULT'
}