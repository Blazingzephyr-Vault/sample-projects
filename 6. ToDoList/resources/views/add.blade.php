@extends('template')
@section('title')
Add Task
@endsection

@section('nav1-class')
active
@endsection

@section('body')
    @if($errors->any())
        <div class="alert alert-danger">
            <ul>
                @foreach($errors->all() as $error)
                <li>{{ $error }}</li>
                @endforeach
            </ul>
        </div>
    @endif 

    <form method="POST" action="add-task">
        <input type="hidden" name="_token" value="{{ csrf_token() }}" />
        <ul>
            <li>Title:<br></li>
            <li><input type="text" name="title" value="{{ old('title') }}"><br><br></li>
            <li>Description:<br></li>
            <li><input type="text" name="description" value="{{ old('description') }}"><br><br></li>
            <li>Starts:<br></li>
            <li><input type="datetime-local" name="starts" value="{{ old('starts') }}"><br><br></li>
            <li>Ends:<br></li>
            <li><input type="datetime-local" name="ends" value="{{ old('ends') }}"><br><br></li>
            <li>Status:<br></li>
            <li><select name="status">
                <option value="Started">Started</option>
                <option value="In Progress">In Progress</option>
                <option value="Completed">Completed</option>
            </select><br><br><li>
            <input type="submit">
        </ul>
    </form>
@endsection