@extends('layouts.app')

@section('title', 'Product Details')

@section('content')
<div class="row justify-content-center">
    <div class="col-md-10">
        <div class="card">
            <div class="card-header d-flex justify-content-between align-items-center">
                <h3 class="mb-0">Product Details</h3>
                <div>
                    <a href="{{ route('products.edit', $product) }}" class="btn btn-warning">
                        <i class="bi bi-pencil"></i> Edit
                    </a>
                </div>
            </div>
            <div class="card-body">
                <div class="row">
                    <div class="col-md-5">
                        @if($product->image_path)
                            <img src="{{ Storage::url($product->image_path) }}" alt="{{ $product->name }}" class="img-fluid rounded">
                        @else
                            <div class="bg-secondary bg-opacity-25 d-flex align-items-center justify-content-center rounded" style="height: 400px;">
                                <i class="bi bi-image text-muted" style="font-size: 3rem;"></i>
                            </div>
                        @endif
                    </div>
                    <div class="col-md-7">
                        <h2>{{ $product->name }}</h2>
                        <h4 class="text-primary">${{ number_format($product->price, 2) }}</h4>

                        <div class="mt-4">
                            <h5>Description</h5>
                            <p>{{ $product->description ?? 'No description available.' }}</p>
                        </div>

                        @if($product->external_api_data)
                            <div class="mt-4">
                                <h5>External API Data</h5>
                                <p>{{ $product->external_api_data }}</p>
                            </div>
                        @endif

                        <div class="mt-4">
                            <h5>Product Information</h5>
                            <table class="table table-sm">
                                <tr>
                                    <td width="150"><strong>ID:</strong></td>
                                    <td>{{ $product->id }}</td>
                                </tr>
                                <tr>
                                    <td><strong>Created At:</strong></td>
                                    <td>{{ $product->created_at->format('d/m/Y H:i:s') }}</td>
                                </tr>
                                <tr>
                                    <td><strong>Updated At:</strong></td>
                                    <td>{{ $product->updated_at->format('d/m/Y H:i:s') }}</td>
                                </tr>
                            </table>
                        </div>
                    </div>
                </div>

                <div class="mt-4">
                    <a href="{{ route('products.index') }}" class="btn btn-secondary">
                        <i class="bi bi-arrow-left"></i> Back to Products
                    </a>
                    <a href="{{ route('products.edit', $product) }}" class="btn btn-warning ms-2">
                        <i class="bi bi-pencil"></i> Edit
                    </a>

                    <form action="{{ route('products.destroy', $product) }}" method="POST" class="d-inline" onsubmit="return confirm('Are you sure you want to delete this product?');">
                        @csrf
                        @method('DELETE')
                        <button type="submit" class="btn btn-danger ms-2">
                            <i class="bi bi-trash"></i> Delete
                        </button>
                    </form>
                </div>
            </div>
        </div>
    </div>
</div>
@endsection
