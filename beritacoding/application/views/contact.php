<!DOCTYPE html>
<html>
<head>
	<title>About Us</title>
	<!-- Bootstrap CSS -->
	<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
	<!-- Custom CSS -->
	<style>
		.footer {
			position: absolute;
			bottom: 0;
			width: 100%;
			height: 60px; /*tinggi footer*/
		}
		.navbar-custom, .footer, .btn {
			background-color: #2A2F4F;
			color: white;
		}
		.jumbotron{
			background-color: #E3DFFD;
			color: black;
		}
        .btn {
            border: none;
        }
        .btn:hover {
            background-color: #E3DFFD;
			color: black;
        }
	</style>
</head>
<body>
    <!-- Navigation bar -->
	<nav class="navbar navbar-expand-lg navbar-dark navbar-custom">
		<a class="navbar-brand" href="http://localhost/beritacoding/index.php">Rycahaya</a>
		<button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
			<span class="navbar-toggler-icon"></span>
		</button>
		<div class="collapse navbar-collapse" id="navbarNav">
			<ul class="navbar-nav">
				<li class="nav-item ">
					<a class="nav-link" href="http://localhost/beritacoding/index.php">Home</a>
				</li>
				<li class="nav-item ">
					<a class="nav-link" href="http://localhost/beritacoding/index.php/about">About</a>
				</li>
				<li class="nav-item active">
					<a class="nav-link" href="http://localhost/beritacoding/index.php/contact">Contact</a>
				</li>
			</ul>
		</div>
	</nav>

    <div class="container">
    <h1 class="text-center mt-5">Contact Us</h1>
    <hr>
    <div class="row">
        <div class="col-md-6">
        <form>
            <div class="form-group">
            <label for="name">Nama</label>
            <input type="text" class="form-control" id="name">
            </div>
            <div class="form-group">
            <label for="email">Email</label>
            <input type="email" class="form-control" id="email">
            </div>
            <div class="form-group">
            <label for="message">Pesan</label>
            <textarea class="form-control" id="message" rows="5"></textarea>
            </div>
            <button type="submit" class="btn btn-primary">Kirim</button>
        </form>
        </div>
        <div class="col-md-6">
        <h3>Contact Info</h3>
        <p>Institut Teknologi Sepuluh Nopember</p>
        <p>Fakultas Teknologi Elektro dan Informatika Cerdas</p>
        <p>Departemen Teknik Informatika</p>
        </div>
    </div>
    </div>

    <!-- Footer -->
	<footer class="py-3 footer">
		<div class="container">
			<p class="text-center">&copy; 2023 Rycahaya Sri Hutomo</p>
		</div>
	</footer>

	<!-- Bootstrap JavaScript -->
	<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
	<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
	<script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>

</body>
</html>