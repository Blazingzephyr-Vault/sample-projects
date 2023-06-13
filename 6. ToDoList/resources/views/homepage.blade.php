@extends('template')
@section('nav1-class')
@endsection

@section('title')
TODO List
@endsection

@section('body')
    @foreach($data as $e)
        <h3><?php echo $e['title'] ?></h3>
        <ul>
            <li><h5><?php echo $e['description'] ?></h5></li>
            <li><h5>Status: <?php echo $e['status'] ?></h5></li>
            <li><h5>Starts: <?php echo $e['starts'] ?></h5></li>
            <li><h5>Ends: <?php echo $e['ends'] ?></h5></li>
        </ul>

        <form action="update" method="get">
            <input type="hidden" name="_token" value="{{ csrf_token() }}" />
                <?php echo '<input type="hidden" value="'.$e['id'].'" name="id">'; ?>
            <input type="submit" value="Update">
        </form>

        <form action="delete-task" method="post">
            <input type="hidden" name="_token" value="{{ csrf_token() }}" />
                <?php echo '<input type="hidden" value="'.$e['id'].'" name="id">'; ?>
            <input type="submit" value="Delete">
        </form><br><br>
    @endforeach
@endsection