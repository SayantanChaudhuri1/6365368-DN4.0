// Posts.js
import React from 'react';
import Post from './Post';

class Posts extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
      posts: [],
      hasError: false
    };
  }

  componentDidMount() {
    this.loadPosts();
  }

  loadPosts() {
    try {
      // Dummy data
      const dummyPosts = [
        { id: 1, title: 'First Post', body: 'This is the first post body.' },
        { id: 2, title: 'Second Post', body: 'This is the second post body.' },
        { id: 3, title: 'Third Post', body: 'This is the third post body.' }
      ];
      this.setState({ posts: dummyPosts });
    } catch (error) {
      this.setState({ hasError: true });
    }
  }

  componentDidCatch(error, info) {
    alert("Something went wrong!");
    console.error("Error Caught in componentDidCatch: ", error, info);
  }

  render() {
    const { posts, hasError } = this.state;

    if (hasError) {
      return <h2 style={{ color: 'red', textAlign: 'center' }}>Error loading posts!</h2>;
    }

    return (
      <div style={{ textAlign: 'center', marginTop: '40px' }}>
        <h1 style={{ marginBottom: '30px' }}>Post List</h1>
        <div style={{ display: 'flex', flexDirection: 'column', gap: '20px', alignItems: 'center' }}>
          {posts.map(post => (
            <div key={post.id} style={{ textAlign: 'left' }}>
              <p><strong>{post.title}</strong></p>
              <p>{post.body}</p>
            </div>
          ))}
        </div>
      </div>
    );
  }
}

export default Posts;
