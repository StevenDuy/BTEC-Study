<!doctype html>
<html lang="en">

<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Bootstrap demo</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.6/dist/css/bootstrap.min.css" rel="stylesheet"
        integrity="sha384-4Q6Gf2aSP4eDXB8Miphtr37CMZZQ5oXLH2yaXMJ2w8e2ZtHTl7GptT4jmndRuHDT" crossorigin="anonymous">
    <script src="https://kit.fontawesome.com/a4137b8c56.js" crossorigin="anonymous"></script>
    <style>
        /* Fix card image size for consistent layout */
        .card-img-top {
            width: 100%;
            height: 220px;
            object-fit: cover;
            object-position: center;
            background: #f8f9fa;
        }
    </style>
</head>

<body>
    <nav class="navbar fixed-top navbar-expand-md bg-dark navbar-dark shadow-sm">
        <div class="container-fluid">
            <a class="navbar-brand fw-bold" href="#">Y6187419 Spa</a>
            <button class="navbar-toggler" type="button" data-bs-toggle="collapse"
                data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false"
                aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse" id="navbarSupportedContent">
                <ul class="navbar-nav me-auto mb-2 mb-lg-0">
                    <li class="nav-item">
                        <a class="nav-link active" aria-current="page" href="#">Trang chủ</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="#">Liên hệ</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="#">Về công ty</a>
                    </li>
                </ul>
                <div class="d-flex align-items-center gap-3">
                    <div class="position-relative me-2">
                        <i class="fa fa-shopping-cart fa-lg text-white"></i>
                        <span class="position-absolute top-0 start-100 translate-middle badge rounded-pill bg-danger" style="font-size:0.7rem;">0</span>
                    </div>
                    <button type="button" class="btn btn-primary px-4 fw-bold" data-bs-toggle="modal" data-bs-target="#loginModal" style="border-radius: 2rem; background: linear-gradient(90deg, #5f6cff 0%, #7f53ff 100%); border: none;">
                        Login
                    </button>
                </div>
            </div>
        </div>
    </nav>

    <div class="w-100" style="margin-top: 70px;">


        <div id="carouselExampleIndicators" class="carousel slide">
            <div class="carousel-indicators">
                <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="0" class="active"
                    aria-current="true" aria-label="Slide 1"></button>
                <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="1"
                    aria-label="Slide 2"></button>
                <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="2"
                    aria-label="Slide 3"></button>
            </div>
            <div class="carousel-inner">
                <div class="carousel-item active">
                    <img class="img-fluid" src="assets/images/banner.png" alt="">
                </div>
                <div class="carousel-item">
                    <img class="img-fluid" src="assets/images/banner.png" alt="">
                </div>
                <div class="carousel-item">
                    <img class="img-fluid" src="assets/images/banner.png" alt="">
                </div>
            </div>
            <button class="carousel-control-prev" type="button" data-bs-target="#carouselExampleIndicators"
                data-bs-slide="prev">
                <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                <span class="visually-hidden">Previous</span>
            </button>
            <button class="carousel-control-next" type="button" data-bs-target="#carouselExampleIndicators"
                data-bs-slide="next">
                <span class="carousel-control-next-icon" aria-hidden="true"></span>
                <span class="visually-hidden">Next</span>
            </button>
        </div>
    </div>

    <div class="container py-5">
        <h1 class="mb-4 fw-bold">Sản phẩm nổi bật</h1>
        <div class="row">
            <div class="col-12 col-sm-6 col-md-4 col-lg-3 mb-4">
                <div class="card h-100 shadow">
                    
                        <img  src="assets/images/product2.png" 
                    class="card-img-top" alt="...">
                    <div class="card-body d-flex flex-column justify-content-between">
                        <h5 class="card-title">Tinh dầu thiên nhiên</h5>
                        <p class="card-text">Tinh dầu nguyên chất giúp thư giãn và làm dịu tâm trí.</p>
                        <div class="mb-2 fw-bold text-success fs-5">150.000₫</div>
                        <div class="d-flex justify-content-center">
                            <button class="btn btn-outline-primary d-flex align-items-center px-4">
                                <i class="fa fa-cart-plus me-2"></i> Add to cart
                            </button>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-12 col-sm-6 col-md-4 col-lg-3 mb-4">
                <div class="card h-100 shadow">
                    <img src="assets/images/product.png" class="card-img-top" alt="...">
                    <div class="card-body d-flex flex-column justify-content-between">
                        <h5 class="card-title">Nến thơm spa</h5>
                        <p class="card-text">Nến thơm giúp không gian thêm ấm áp và thư giãn.</p>
                        <div class="mb-2 fw-bold text-success fs-5">120.000₫</div>
                        <div class="d-flex justify-content-center">
                            <button class="btn btn-outline-primary d-flex align-items-center px-4">
                                <i class="fa fa-cart-plus me-2"></i> Add to cart
                            </button>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-12 col-sm-6 col-md-4 col-lg-3 mb-4">
                <div class="card h-100 shadow">
                    <img src="assets/images/product.png" class="card-img-top" alt="...">
                    <div class="card-body d-flex flex-column justify-content-between">
                        <h5 class="card-title">Muối tắm Himalaya</h5>
                        <p class="card-text">Muối tắm giúp làm sạch và dưỡng da hiệu quả.</p>
                        <div class="mb-2 fw-bold text-success fs-5">90.000₫</div>
                        <div class="d-flex justify-content-center">
                            <button class="btn btn-outline-primary d-flex align-items-center px-4">
                                <i class="fa fa-cart-plus me-2"></i> Add to cart
                            </button>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-12 col-sm-6 col-md-4 col-lg-3 mb-4">
                <div class="card h-100 shadow">
                    <img src="assets/images/product.png" class="card-img-top" alt="...">
                    <div class="card-body d-flex flex-column justify-content-between">
                        <h5 class="card-title">Bộ quà tặng spa</h5>
                        <p class="card-text">Bộ quà tặng sang trọng cho người thân yêu.</p>
                        <div class="mb-2 fw-bold text-success fs-5">350.000₫</div>
                        <div class="d-flex justify-content-center">
                            <button class="btn btn-outline-primary d-flex align-items-center px-4">
                                <i class="fa fa-cart-plus me-2"></i> Add to cart
                            </button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- FAQ Accordion -->
        <div class="mt-5">
            <h2 class="mb-3 fw-bold">FAQ</h2>
            <div class="accordion" id="faqAccordion">
                <div class="accordion-item">
                    <h2 class="accordion-header" id="faq1">
                        <button class="accordion-button" type="button" data-bs-toggle="collapse" data-bs-target="#collapse1" aria-expanded="true" aria-controls="collapse1">
                            Sản phẩm có nguồn gốc từ đâu?
                        </button>
                    </h2>
                    <div id="collapse1" class="accordion-collapse collapse show" aria-labelledby="faq1" data-bs-parent="#faqAccordion">
                        <div class="accordion-body">
                            Tất cả sản phẩm đều có nguồn gốc tự nhiên, an toàn cho sức khỏe.
                        </div>
                    </div>
                </div>
                <div class="accordion-item">
                    <h2 class="accordion-header" id="faq2">
                        <button class="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#collapse2" aria-expanded="false" aria-controls="collapse2">
                            Làm sao để đặt hàng?
                        </button>
                    </h2>
                    <div id="collapse2" class="accordion-collapse collapse" aria-labelledby="faq2" data-bs-parent="#faqAccordion">
                        <div class="accordion-body">
                            Bạn chỉ cần nhấn nút "Add to cart" và làm theo hướng dẫn để hoàn tất đơn hàng.
                        </div>
                    </div>
                </div>
                <div class="accordion-item">
                    <h2 class="accordion-header" id="faq3">
                        <button class="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#collapse3" aria-expanded="false" aria-controls="collapse3">
                            Tôi có thể đổi trả sản phẩm không?
                        </button>
                    </h2>
                    <div id="collapse3" class="accordion-collapse collapse" aria-labelledby="faq3" data-bs-parent="#faqAccordion">
                        <div class="accordion-body">
                            Bạn có thể đổi trả sản phẩm trong vòng 7 ngày nếu có lỗi từ nhà sản xuất.
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <!-- Login Modal -->
    <div class="modal fade" id="loginModal" tabindex="-1" aria-labelledby="loginModalLabel" aria-hidden="true">
        <div class="modal-dialog modal-dialog-centered">
            <div class="modal-content p-2 p-md-4">
                <div class="modal-header border-0 pb-0">
                    <h5 class="modal-title w-100 text-center fw-bold fs-4" id="loginModalLabel">Đăng nhập</h5>
                    <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                </div>
                <div class="modal-body pt-0">
                    <div class="d-flex flex-column align-items-center mb-3">
                        <div class="bg-primary bg-gradient rounded-circle d-flex align-items-center justify-content-center" style="width: 60px; height: 60px;">
                            <i class="fa fa-user fa-2x text-white"></i>
                        </div>
                    </div>
                    <form>
                        <div class="mb-3">
                            <input type="text" class="form-control" id="LoginUsername"
                             placeholder="administrator" >
                        </div>
                        <div class="mb-3 position-relative">
                            <input type="password" class="form-control" id="LoginPassword"
                             placeholder="Mật khẩu" >
                            <span class="position-absolute top-50 end-0 translate-middle-y me-3"
                             style="cursor:pointer;" onclick="const p=document.getElementById('LoginPassword');p.type=p.type==='password'?'text':'password';this.querySelector('i').classList.toggle('fa-eye');this.querySelector('i').classList.toggle('fa-eye-slash');">
                                <i class="fa fa-eye-slash"></i>
                            </span>
                        </div>
                        <div class="mb-3 text-end">
                            <a href="#" class="text-decoration-none">Quên mật khẩu?</a>
                        </div>
                        <button type="button" onclick="submitLoginForm()"
                            class="btn btn-primary w-100 py-2 fw-bold fs-5">Đăng nhập</button>
                    </form>
                </div>
            </div>
        </div>
    </div>

    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.11.8/dist/umd/popper.min.js"
        integrity="sha384-I7E8VVD/ismYTF4hNIPjVp/Zjvgyol6VFvRkX/vR+Vc4jQkC+hVqc2pM8ODewa9r"
        crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.6/dist/js/bootstrap.bundle.min.js"
        integrity="sha384-j1CDi7MgGQ12Z7Qab0qlWQ/Qqz24Gc6BM0thvEMVjHnfYGF0rmFCozFSxQBxwHKO"
        crossorigin="anonymous"></script>
        <script src="https://code.jquery.com/jquery-3.7.1.min.js" integrity="sha256-/JqT3SQfawRcv/BIHPThkBvs0OEvtFFmqPF/lYI/Cxo=" crossorigin="anonymous"></script>
        <script src="https://cdn.jsdelivr.net/npm/sweetalert2@11"></script>
        <script src="assets/js/main.js"></script>
</body>
</html>